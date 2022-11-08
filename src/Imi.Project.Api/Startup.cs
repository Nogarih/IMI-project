using Imi.Project.Api.Core.Constants;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using Imi.Project.Api.Core.Services;
using Imi.Project.Api.Infrastructure.Data;
using Imi.Project.Api.Infrastructure.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Imi.Project.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection")));

            // Identity configuration
            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedEmail = false;
            })
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddCors();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "MyWatchList API", Version = "v1" });
            });

            // Repositories
            services.AddScoped<IAnimeRepository, AnimeRepository>();
            services.AddScoped<IDirectorRepository, DirectorRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<ITvSerieRepository, TvSerieRepository>();

            // Services
            services.AddScoped<IAnimeService, AnimeService>();
            services.AddScoped<IDirectorService, DirectorService>();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<ILanguageService, LanguageService>();
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<ITvSerieService, TvSerieService>();
            services.AddScoped<IUserService, UserService>();

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(jwtOptions =>
                {
                    jwtOptions.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateActor = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = Configuration["JWTConfiguration:Issuer"],
                        ValidAudience = Configuration["JWTConfiguration:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWTConfiguration:SigningKey"]))
                    };
                });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            
            services.AddAuthorization(options =>
            {
                // Only admins can delete
                options.AddPolicy(MyPolicies.CanDelete, policy =>
                {
                    policy.RequireClaim(ClaimTypes.Role, MyUserRoles.Admin);
                });

                // Only users who approved terms and admins can create
                options.AddPolicy(MyPolicies.CanCreate, policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        if (context.User.IsInRole(MyUserRoles.Admin))
                        {
                            return true;
                        }
                        var hasAcceptedTermsClaimValue = context.User.Claims
                        .SingleOrDefault(c => c.Type == MyClaimTypes.HasApprovedTermsClaimType)?.Value;

                        if (context.User.IsInRole(MyUserRoles.User) && hasAcceptedTermsClaimValue == "True")
                        {
                            return true;
                        }
                        return false;
                    });
                });

                // Only users who approved terms and admins can edit
                options.AddPolicy(MyPolicies.CanEdit, policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        if (context.User.IsInRole(MyUserRoles.Admin))
                        {
                            return true;
                        }
                        var hasAcceptedTermsClaimValue = context.User.Claims
                        .SingleOrDefault(c => c.Type == MyClaimTypes.HasApprovedTermsClaimType)?.Value;

                        if (context.User.IsInRole(MyUserRoles.User) && hasAcceptedTermsClaimValue == "True")
                        {
                            return true;
                        }
                        return false;
                    });
                });

                // Everyone who approved terms and admins can read
                options.AddPolicy(MyPolicies.CanRead, policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        if (context.User.IsInRole(MyUserRoles.Admin))
                        {
                            return true;
                        }
                        var hasAcceptedTermsClaimValue = context.User.Claims
                        .SingleOrDefault(c => c.Type == MyClaimTypes.HasApprovedTermsClaimType)?.Value;

                        if (hasAcceptedTermsClaimValue == "True")
                        {
                            return true;
                        }
                        return false;
                    });
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyWatchList API");
                c.RoutePrefix = string.Empty;
            });

             app.UseCors(builder => builder
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod());

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication(); 
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
