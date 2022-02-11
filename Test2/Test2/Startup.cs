using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Daihoc_FPT_News.Models;
using Daihoc_FPT_News.Repository;
using Daihoc_FPT_News.Util;
using Microsoft.EntityFrameworkCore;

namespace Daihoc_FPT_News
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
            //services.AddMvc(options =>
            //{
            //    // xu li language
            //    options.Filters.Add<ViewBagActionFilter>();
            //    options.EnableEndpointRouting = false;
            //}).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddDbContext<DaihocFPTNewsContext>(item => item.UseSqlServer(Configuration.GetConnectionString("DBConnection")));

            //services.AddScoped<IAccountTypeRepository, AccountTypeRepository>();

            //services.AddScoped<IAccountMetaRepository, AccountMetaRepository>();

            //services.AddScoped<IAccountRepository, AccountRepository>();

            //services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();

            //services.AddScoped<INotificationRepository, NotificationRepository>();

            //services.AddScoped<IMessageRepository, MessageRepository>();

            //services.AddScoped<IProvinceRepository, ProvinceRepository>();

            //services.AddScoped<ISystemConfigRepository, SystemConfigRepository>();

            //services.AddScoped<IPostTypeRepository, PostTypeRepository>();

            //services.AddScoped<IPostCategoryRepository, PostCategoryRepository>();

            //services.AddScoped<IPostLayoutRepository, PostLayoutRepository>();

            //services.AddScoped<IPostMetaRepository, PostMetaRepository>();

            //services.AddScoped<IPostRepository, PostRepository>();

            services.AddScoped<IMenuRepository, MenuRepository>();

            //services.AddScoped<ILanguageConfigRepository, LanguageConfigRepository>();

            //services.AddScoped<ITagRepository, TagRepository>();

            //services.AddScoped<IFavouritePostRepository, FavouritePostRepository>();

            //services.AddScoped<IActivityLogRepository, ActivityLogRepository>();

            //services.AddScoped<IViewStatusRepository, ViewStatusRepository>();

            //services.AddScoped<ISubscribeRepository, SubscribeRepository>();

            services.AddSingleton<ICacheHelper, CacheHelper>();

            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromSeconds(3600);
            });
            //services.AddScoped<ICommentRepository, CommentRepository>();

            //services.AddScoped<IPostTagRepository, PostTagRepository>();

            //services.AddScoped<IReadedPostRepository, ReadedPostRepository>();


            //services.AddScoped<ITopicRepository, TopicRepository>();

            //services.AddScoped<IPostTopicRepository, PostTopicRepository>();

            //services.AddScoped<IFeaturedPostRepository, FeaturedPostRepository>();

            //services.AddScoped<IEventRequestStatusRepository, EventRequestStatusRepository>();

            //services.AddScoped<IEventRequestRepository, EventRequestRepository>();


            //services.AddScoped<ISurveyTypeRepository, SurveyTypeRepository>();

            //services.AddScoped<ISurveyRepository, SurveyRepository>();

            //services.AddScoped<ISurveyMetaRepository, SurveyMetaRepository>();

            //services.AddScoped<ISurveySectionRepository, SurveySectionRepository>();

            //services.AddScoped<IQuestionTypeRepository, QuestionTypeRepository>();

            //services.AddScoped<IQuestionRepository, QuestionRepository>();

            //services.AddScoped<IAnswerRepository, AnswerRepository>();

            //services.AddScoped<ISurveySectionQuestionRepository, SurveySectionQuestionRepository>();

            //services.AddScoped<ISurveyAccountRepository, SurveyAccountRepository>();

            //services.AddScoped<ISurveySectionAccountRepository, SurveySectionAccountRepository>();

            //services.AddScoped<ISurveySectionAccountDetailRepository, SurveySectionAccountDetailRepository>();

            //services.AddScoped<IRecommentRepository, RecommentRepository>();

            //services.AddScoped<IOrganizationTypeRepository, OrganizationTypeRepository>();

            //services.AddScoped<IContactRepository, ContactRepository>();
            //services.AddScoped<IOrganizationRepository, OrganizationRepository>();

            //services.AddScoped<IEnterpriseTypeRepository, EnterpriseTypeRepository>();

            //services.AddScoped<IFinancialProductTypeRepository, FinancialProductTypeRepository>();

            //services.AddScoped<IFinancialProductRepository, FinancialProductRepository>();

            //services.AddScoped<IFinancialProductDetailRepository, FinancialProductDetailRepository>();

            //services.AddScoped<IPreferentialTypeRepository, PreferentialTypeRepository>();
            //services.AddScoped<IPreferentialTypeRepository, PreferentialTypeRepository>();

            //services.AddScoped<IPreferentialProductRepository, PreferentialProductRepository>();

            //services.AddScoped<IPreferentialProductDetailRepository, PreferentialProductDetailRepository>();



            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");

                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
