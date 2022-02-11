using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

//Scaffold-DbContext "Server=123.31.12.46;Database=A2F;UID=a2f;PWD=X2JX69DAdiELLGcO;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir ModelsA2F

namespace Daihoc_FPT_News.Models
{
    public partial class DaihocFPTNewsContext : DbContext
    {
        public DaihocFPTNewsContext()
        {
        }

        public DaihocFPTNewsContext(DbContextOptions<DaihocFPTNewsContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<Account> Account { get; set; }
        //public virtual DbSet<AccountMeta> AccountMeta { get; set; }
        //public virtual DbSet<AccountType> AccountType { get; set; }
        //public virtual DbSet<ViewStatus> ViewStatus { get; set; }
        //public virtual DbSet<ActivityLog> ActivityLog { get; set; }
        //public virtual DbSet<Authentication> Authentication { get; set; }
        //public virtual DbSet<Comment> Comment { get; set; }
        //public virtual DbSet<FavouritePost> FavouritePost { get; set; }
        //public virtual DbSet<FeaturedPost> FeaturedPost { get; set; }
        //public virtual DbSet<ReadedPost> ReadedPost { get; set; }
        //public virtual DbSet<LanguageConfig> LanguageConfig { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        //public virtual DbSet<Message> Message { get; set; }
        //public virtual DbSet<Notification> Notification { get; set; }
        //public virtual DbSet<Post> Post { get; set; }
        //public virtual DbSet<PostCategory> PostCategory { get; set; }
        //public virtual DbSet<PostLayout> PostLayout { get; set; }
        //public virtual DbSet<PostMeta> PostMeta { get; set; }
        //public virtual DbSet<PostTopic> PostTopic { get; set; }
        //public virtual DbSet<PostTag> PostTag { get; set; }
        //public virtual DbSet<PostType> PostType { get; set; }
        //public virtual DbSet<Province> Province { get; set; }
        //public virtual DbSet<SystemConfig> SystemConfig { get; set; }
        //public virtual DbSet<Tag> Tag { get; set; }
        //public virtual DbSet<Topic> Topic { get; set; }
        //public virtual DbSet<Subscribe> Subscribe { get; set; }

        //public virtual DbSet<EventRequest> EventRequest { get; set; }
        //public virtual DbSet<EventRequestStatus> EventRequestStatus { get; set; }


        //public virtual DbSet<Answer> Answer { get; set; }

        //public virtual DbSet<Question> Question { get; set; }
        //public virtual DbSet<QuestionType> QuestionType { get; set; }

        //public virtual DbSet<Survey> Survey { get; set; }
        //public virtual DbSet<SurveyAccount> SurveyAccount { get; set; }
        //public virtual DbSet<SurveyMeta> SurveyMeta { get; set; }
        //public virtual DbSet<SurveySection> SurveySection { get; set; }
        //public virtual DbSet<SurveySectionAccount> SurveySectionAccount { get; set; }
        //public virtual DbSet<SurveySectionAccountDetail> SurveySectionAccountDetail { get; set; }
        //public virtual DbSet<Recomment> Recomment { get; set; }

        //public virtual DbSet<SurveySectionQuestion> SurveySectionQuestion { get; set; }
        //public virtual DbSet<SurveyType> SurveyType { get; set; }
        //public virtual DbSet<Contact> Contact { get; set; }

        //public virtual DbSet<EnterpriseType> EnterpriseType { get; set; }
        //public virtual DbSet<FinancialProduct> FinancialProduct { get; set; }
        //public virtual DbSet<FinancialProductDetail> FinancialProductDetail { get; set; }
        //public virtual DbSet<FinancialProductType> FinancialProductType { get; set; }
        //public virtual DbSet<Organization> Organization { get; set; }
        //public virtual DbSet<OrganizationType> OrganizationType { get; set; }
        //public virtual DbSet<PreferentialProduct> PreferentialProduct { get; set; }
        //public virtual DbSet<PreferentialProductDetail> PreferentialProductDetail { get; set; }
        //public virtual DbSet<PreferentialType> PreferentialType { get; set; }


        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer("Server=DESKTOP-4PAUV2F;Database=GW;UID=sa;PWD=123456;");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            //modelBuilder.Entity<Account>(entity =>
            //{
            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

            //    entity.Property(e => e.Address)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Email)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Info).HasColumnType("ntext");


            //    entity.Property(e => e.IdCardNumber).HasColumnType("ntext");
            //    entity.Property(e => e.CompanyNumber).HasColumnType("ntext");
            //    entity.Property(e => e.CompanyName).HasColumnType("ntext");
            //    entity.Property(e => e.CompanyInfo).HasColumnType("ntext");
            //    entity.Property(e => e.GoogleId).HasColumnType("ntext");
            //    entity.Property(e => e.FacebookId).HasColumnType("ntext");


            //    entity.Property(e => e.Name)
            //                .IsRequired()
            //                .HasMaxLength(255);

            //    entity.Property(e => e.Password)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Phone)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Photo).HasColumnType("ntext");
            //    entity.Property(e => e.IsActivated).HasColumnName("IsActivated");

            //    entity.Property(e => e.Username)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.HasOne(d => d.AccountType)
            //        .WithMany(p => p.Account)
            //        .HasForeignKey(d => d.AccountTypeId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_account_accountTypeID");
            //});
            //modelBuilder.Entity<Contact>(entity =>
            //{
            //    entity.Property(e => e.CompanyName)
            //        .IsRequired()
            //        .HasColumnType("ntext");

            //    entity.Property(e => e.CompanyNumber)
            //        .IsRequired()
            //        .HasColumnType("ntext");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Email)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Phone)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.HasOne(d => d.Account)
            //        .WithMany(p => p.Contact)
            //        .HasForeignKey(d => d.AccountId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_Contact_accountID");

            //    entity.HasOne(d => d.SurveyAccount)
            //        .WithMany(p => p.Contact)
            //        .HasForeignKey(d => d.SurveyAccountId)
            //        .HasConstraintName("FK_Contact_surveyAccountID");
            //});
            //modelBuilder.Entity<AccountMeta>(entity =>
            //{
            //    entity.HasIndex(e => e.Name)
            //        .HasName("UQ__AccountM__737584F6D88DA63E")
            //        .IsUnique();

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.AccountId).HasColumnName("AccountID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.HasOne(d => d.Account)
            //        .WithMany(p => p.AccountMeta)
            //        .HasForeignKey(d => d.AccountId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_accountMeta_accountID");
            //});

            //modelBuilder.Entity<AccountType>(entity =>
            //{
            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<AccountType>(entity =>
            //{
            //    entity.HasIndex(e => e.Name)
            //        .HasName("UQ__Province__737584F67664A785")
            //        .IsUnique();

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<ViewStatus>(entity =>
            //{
            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<ActivityLog>(entity =>
            //{
            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.AccountId).HasColumnName("AccountID");

            //    entity.Property(e => e.Browser)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Device)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.IpAddress)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Os)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Url)
            //        .IsRequired()
            //        .HasColumnType("ntext");

            //    entity.Property(e => e.UrlSource)
            //        .IsRequired()
            //        .HasColumnType("ntext");

            //    entity.Property(e => e.UserAgent).HasColumnType("ntext");

            //    entity.HasOne(d => d.Account)
            //        .WithMany(p => p.ActivityLog)
            //        .HasForeignKey(d => d.AccountId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_activityLog_accountID");
            //});

            //modelBuilder.Entity<Authentication>(entity =>
            //{
            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.AccountId).HasColumnName("AccountID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Token)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.ValidTime).HasColumnType("datetime");

            //    entity.HasOne(d => d.Account)
            //        .WithMany(p => p.Authentication)
            //        .HasForeignKey(d => d.AccountId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_authentication_accountID");
            //});

            //modelBuilder.Entity<Comment>(entity =>
            //{
            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.AccountId).HasColumnName("AccountID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");
            //    entity.Property(e => e.Email).HasColumnType("ntext");
            //    entity.Property(e => e.Text).HasColumnType("ntext");
            //    entity.Property(e => e.Website).HasColumnType("ntext");
            //    entity.Property(e => e.IsChecked).HasColumnName("IsChecked");


            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasColumnType("ntext");

            //    entity.Property(e => e.PostId).HasColumnName("PostID");

            //    entity.HasOne(d => d.Account)
            //        .WithMany(p => p.Comment)
            //        .HasForeignKey(d => d.AccountId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_comment_accountID");

            //    entity.HasOne(d => d.Post)
            //        .WithMany(p => p.Comment)
            //        .HasForeignKey(d => d.PostId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_comment_postID");
            //});

            //modelBuilder.Entity<FavouritePost>(entity =>
            //{
            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.AccountId).HasColumnName("AccountID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasColumnType("ntext");

            //    entity.Property(e => e.PostId).HasColumnName("PostID");

            //    entity.HasOne(d => d.Account)
            //        .WithMany(p => p.FavouritePost)
            //        .HasForeignKey(d => d.AccountId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_favouritePost_accountID");

            //    entity.HasOne(d => d.Post)
            //        .WithMany(p => p.FavouritePost)
            //        .HasForeignKey(d => d.PostId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_favouritePost_postID");
            //});



            //modelBuilder.Entity<ReadedPost>(entity =>
            //{
            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.AccountId).HasColumnName("AccountID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasColumnType("ntext");

            //    entity.Property(e => e.PostId).HasColumnName("PostID");

            //    entity.HasOne(d => d.Account)
            //        .WithMany(p => p.ReadedPost)
            //        .HasForeignKey(d => d.AccountId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_readedPost_accountID");

            //    entity.HasOne(d => d.Post)
            //        .WithMany(p => p.ReadedPost)
            //        .HasForeignKey(d => d.PostId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_readedPost_postID");
            //});

            //modelBuilder.Entity<LanguageConfig>(entity =>
            //{
            //    entity.HasIndex(e => e.Code)
            //        .HasName("UQ__Language__A25C5AA721817460")
            //        .IsUnique();

            //    entity.HasIndex(e => e.Name)
            //        .HasName("UQ__Language__737584F65FA65ED2")
            //        .IsUnique();

            //    entity.HasIndex(e => e.Name2)
            //        .HasName("UQ__Language__44C034D9BDB373EB")
            //        .IsUnique();

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Code)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            modelBuilder.Entity<Menu>(entity =>
            {
                //entity.HasIndex(e => e.Name)
                //    .HasName("UQ__Menu__737584F6E3F41B53")
                //    .IsUnique();

                //entity.HasIndex(e => e.Name2)
                //    .HasName("UQ__Menu__44C034D989552D62")
                //    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.GroupID).HasColumnName("GroupID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                //entity.Property(e => e.Name2)
                //    .IsRequired()
                //    .HasMaxLength(255);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnType("ntext");

                //entity.Property(e => e.Url2)
                //    .IsRequired()
                //    .HasColumnType("ntext");
            });

            //modelBuilder.Entity<Message>(entity =>
            //{
            //    entity.Property(e => e.Id).HasColumnName("ID");
            //    entity.Property(e => e.IsChecked).HasColumnName("IsChecked");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Sender)
            //        .IsRequired()
            //        .HasColumnType("ntext");

            //    entity.Property(e => e.Source)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<Notification>(entity =>
            //{
            //    entity.Property(e => e.Id).HasColumnName("ID");
            //    entity.Property(e => e.IsChecked).HasColumnName("IsChecked");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<Post>(entity =>
            //{
            //    //entity.HasIndex(e => e.GuId)
            //    //    .HasName("UQ__Post__A2B66AE56565CCF1")
            //    //    .IsUnique();

            //    //entity.HasIndex(e => e.Url)
            //    //    .HasName("UQ__Post__C5B2143168D84599")
            //    //    .IsUnique();

            //    //entity.HasIndex(e => e.Url2)
            //    //    .HasName("UQ__Post__BDE2876F28ABAF4B")
            //    //    .IsUnique();

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Description2).HasColumnType("ntext");

            //    entity.Property(e => e.GuId)
            //        .HasColumnName("GuID")
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2).HasMaxLength(255);

            //    entity.Property(e => e.Photo).HasMaxLength(255);

            //    entity.Property(e => e.PostAccountId).HasColumnName("PostAccountID");

            //    entity.Property(e => e.PostCategoryId).HasColumnName("PostCategoryID");

            //    entity.Property(e => e.PostCommentStatusId).HasColumnName("PostCommentStatusID");

            //    entity.Property(e => e.PostLayoutId).HasColumnName("PostLayoutID");

            //    entity.Property(e => e.PostPublishStatusId).HasColumnName("PostPublishStatusID");

            //    entity.Property(e => e.PostTypeId).HasColumnName("PostTypeID");

            //    entity.Property(e => e.PublishedTime).HasColumnType("datetime");

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.Property(e => e.Text2).HasColumnType("ntext");

            //    entity.Property(e => e.Url).HasMaxLength(255);

            //    entity.Property(e => e.Url2).HasMaxLength(255);

            //    entity.Property(e => e.Video).HasMaxLength(255);

            //    entity.HasOne(d => d.PostAccount)
            //        .WithMany(p => p.Post)
            //        .HasForeignKey(d => d.PostAccountId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_post_postAccountID");

            //    entity.HasOne(d => d.PostCategory)
            //        .WithMany(p => p.Post)
            //        .HasForeignKey(d => d.PostCategoryId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_post_postCategoryID");

            //    entity.HasOne(d => d.PostLayout)
            //        .WithMany(p => p.Post)
            //        .HasForeignKey(d => d.PostLayoutId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_post_postLayoutID");

            //    entity.HasOne(d => d.PostType)
            //        .WithMany(p => p.Post)
            //        .HasForeignKey(d => d.PostTypeId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_post_postTypeID");
            //});

            //modelBuilder.Entity<PostCategory>(entity =>
            //{
            //    entity.HasIndex(e => e.Name)
            //        .HasName("UQ__PostCate__737584F6CEAB3C93")
            //        .IsUnique();

            //    entity.HasIndex(e => e.Name2)
            //        .HasName("UQ__PostCate__44C034D9EBF41153")
            //        .IsUnique();

            //    entity.HasIndex(e => e.Slug)
            //        .HasName("UQ__PostCate__BC7B5FB6CE35C7B7")
            //        .IsUnique();

            //    entity.HasIndex(e => e.Slug2)
            //        .HasName("UQ__PostCate__25F321690A6CCABB")
            //        .IsUnique();

            //    entity.Property(e => e.Id).HasColumnName("ID");
            //    entity.Property(e => e.ParentID).HasColumnName("ParentID");
            //    entity.Property(e => e.PostCount).HasColumnName("PostCount");
            //    entity.Property(e => e.Color)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Photo).HasColumnType("ntext");

            //    entity.Property(e => e.Slug)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Slug2)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<PostLayout>(entity =>
            //{
            //    entity.HasIndex(e => e.Name)
            //        .HasName("UQ__PostLayo__737584F63527926D")
            //        .IsUnique();

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<PostMeta>(entity =>
            //{
            //    entity.HasIndex(e => e.Name)
            //        .HasName("UQ__PostMeta__737584F647017F7C")
            //        .IsUnique();

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.PostId).HasColumnName("PostID");

            //    entity.HasOne(d => d.Post)
            //        .WithMany(p => p.PostMeta)
            //        .HasForeignKey(d => d.PostId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_postMeta_postID");
            //});

            //modelBuilder.Entity<PostTag>(entity =>
            //{
            //    entity.HasIndex(e => e.Name)
            //        .HasName("UQ__PostTag__737584F63AB053AC")
            //        .IsUnique();

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.PostId).HasColumnName("PostID");

            //    entity.Property(e => e.TagId).HasColumnName("TagID");

            //    entity.HasOne(d => d.Post)
            //        .WithMany(p => p.PostTag)
            //        .HasForeignKey(d => d.PostId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_postTag_postID");

            //    entity.HasOne(d => d.Tag)
            //        .WithMany(p => p.PostTag)
            //        .HasForeignKey(d => d.TagId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_postTag_tagID");
            //});



            //modelBuilder.Entity<Topic>(entity =>
            //{

            //    entity.HasIndex(e => e.Slug)
            //        .HasName("UQ__Topic__BC8B5FB6875B795E")
            //        .IsUnique();

            //    entity.HasIndex(e => e.Slug2)
            //        .HasName("UQ__Topic__27F321692CF142B5")
            //        .IsUnique();

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Color)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Description2).HasColumnType("ntext");

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.Property(e => e.Text2).HasColumnType("ntext");

            //    entity.Property(e => e.Photo).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Slug)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Slug2)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});


            //modelBuilder.Entity<PostTopic>(entity =>
            //{

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.PostId).HasColumnName("PostID");

            //    entity.Property(e => e.TopicId).HasColumnName("TopicID");

            //    entity.HasOne(d => d.Post)
            //        .WithMany(p => p.PostTopic)
            //        .HasForeignKey(d => d.PostId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_postTopic_postID");

            //    entity.HasOne(d => d.Topic)
            //        .WithMany(p => p.PostTopic)
            //        .HasForeignKey(d => d.TopicId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_postTopic_topicID");
            //});

            //modelBuilder.Entity<PostType>(entity =>
            //{
            //    entity.HasIndex(e => e.Name)
            //        .HasName("UQ__PostType__737584F6208FC7EB")
            //        .IsUnique();

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<Subscribe>(entity =>
            //{
            //    entity.HasIndex(e => e.Name)
            //        .HasName("UQ__PostType__737584F62081234B")
            //        .IsUnique();

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<Province>(entity =>
            //{
            //    entity.HasIndex(e => e.Name)
            //        .HasName("UQ__Province__737584F67664A785")
            //        .IsUnique();

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<SystemConfig>(entity =>
            //{
            //    entity.HasIndex(e => e.Code)
            //        .HasName("UQ__SystemCo__A25C5AA7F9BBB60A")
            //        .IsUnique();

            //    entity.HasIndex(e => e.Name)
            //        .HasName("UQ__SystemCo__737584F67BD7ABB5")
            //        .IsUnique();

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.Code)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<Tag>(entity =>
            //{
            //    entity.HasIndex(e => e.Name)
            //        .HasName("UQ__Tag__737584F66635112E")
            //        .IsUnique();

            //    entity.HasIndex(e => e.Name2)
            //        .HasName("UQ__Tag__44C034D9E199CE54")
            //        .IsUnique();

            //    entity.HasIndex(e => e.Slug)
            //        .HasName("UQ__Tag__BC7B5FB6875B795E")
            //        .IsUnique();

            //    entity.HasIndex(e => e.Slug2)
            //        .HasName("UQ__Tag__25F321692CF142B5")
            //        .IsUnique();

            //    entity.Property(e => e.Id).HasColumnName("ID");

            //    entity.Property(e => e.PostCount).HasColumnName("PostCount");

            //    entity.Property(e => e.Color)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Slug)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Slug2)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});



            //modelBuilder.Entity<EventRequest>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Email).HasMaxLength(255);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasColumnType("ntext");

            //    entity.Property(e => e.Phone).HasMaxLength(255);

            //    entity.HasOne(d => d.Account)
            //        .WithMany(p => p.EventRequest)
            //        .HasForeignKey(d => d.AccountId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_eventRequest_accountId");

            //    entity.HasOne(d => d.EventRequestStatus)
            //        .WithMany(p => p.EventRequest)
            //        .HasForeignKey(d => d.EventRequestStatusId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_eventRequest_eventRequestStatusId");

            //    entity.HasOne(d => d.Post)
            //        .WithMany(p => p.EventRequest)
            //        .HasForeignKey(d => d.PostId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_eventRequest_postId");
            //});

            //modelBuilder.Entity<EventRequestStatus>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<Survey>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Description2).HasColumnType("ntext");

            //    entity.Property(e => e.GuId).HasMaxLength(255);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2).HasMaxLength(255);

            //    entity.Property(e => e.Photo).HasMaxLength(255);

            //    entity.Property(e => e.PublishedTime).HasColumnType("datetime");

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.Property(e => e.Text2).HasColumnType("ntext");

            //    entity.Property(e => e.Url).HasMaxLength(255);

            //    entity.Property(e => e.Url2).HasMaxLength(255);

            //    entity.Property(e => e.Video).HasMaxLength(255);

            //    entity.HasOne(d => d.SurveyType)
            //        .WithMany(p => p.Survey)
            //        .HasForeignKey(d => d.SurveyTypeId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_survey_surveyTypeId");
            //});

            //modelBuilder.Entity<SurveyAccount>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.HasOne(d => d.Account)
            //        .WithMany(p => p.SurveyAccount)
            //        .HasForeignKey(d => d.AccountId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveyAccount_accountId");

            //    entity.HasOne(d => d.Survey)
            //        .WithMany(p => p.SurveyAccount)
            //        .HasForeignKey(d => d.SurveyId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveyAccount_surveyId");
            //});

            //modelBuilder.Entity<SurveyMeta>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Key)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Value)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.HasOne(d => d.Survey)
            //        .WithMany(p => p.SurveyMeta)
            //        .HasForeignKey(d => d.SurveyId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveyMeta_surveyId");
            //});

            //modelBuilder.Entity<SurveySection>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Description2).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2).HasMaxLength(255);

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.Property(e => e.Text2).HasColumnType("ntext");

            //    entity.HasOne(d => d.Survey)
            //        .WithMany(p => p.SurveySection)
            //        .HasForeignKey(d => d.SurveyId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveySection_surveyId");

            //    entity.HasOne(d => d.SurveySectionNavigation)
            //        .WithMany(p => p.InverseSurveySectionNavigation)
            //        .HasForeignKey(d => d.SurveySectionId)
            //        .HasConstraintName("FK_surveySection_surveySectionId");
            //});

            //modelBuilder.Entity<SurveySectionAccount>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.HasOne(d => d.SurveyAccount)
            //        .WithMany(p => p.SurveySectionAccount)
            //        .HasForeignKey(d => d.SurveyAccountId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveySectionAccount_surveyAccountId");
            //});

            //modelBuilder.Entity<Recomment>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.HasOne(d => d.SurveySection)
            //        .WithMany(p => p.Recomment)
            //        .HasForeignKey(d => d.SurveySectionId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_recomment_surveySectionId");
            //});

            //modelBuilder.Entity<SurveySectionAccountDetail>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.HasOne(d => d.Answer)
            //        .WithMany(p => p.SurveySectionAccountDetailAnswer)
            //        .HasForeignKey(d => d.AnswerId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveySectionAccountDetail_answerId");

            //    entity.HasOne(d => d.Question)
            //        .WithMany(p => p.SurveySectionAccountDetailQuestion)
            //        .HasForeignKey(d => d.QuestionId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveySectionAccountDetail_questionId");

            //    entity.HasOne(d => d.SurveySectionAccountNavigation)
            //        .WithMany(p => p.SurveySectionAccountDetail)
            //        .HasForeignKey(d => d.SurveySectionAccount)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveySectionAccountDetail_surveySectionAccount");
            //});

            //modelBuilder.Entity<SurveySectionQuestion>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.HasOne(d => d.Question)
            //        .WithMany(p => p.SurveySectionQuestion)
            //        .HasForeignKey(d => d.QuestionId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveySectionQuestion_questionId");

            //    entity.HasOne(d => d.SurveySection)
            //        .WithMany(p => p.SurveySectionQuestion)
            //        .HasForeignKey(d => d.SurveySectionId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveySectionQuestion_surveySectionId");
            //});

            //modelBuilder.Entity<SurveyType>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});


            //modelBuilder.Entity<Survey>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Description2).HasColumnType("ntext");

            //    entity.Property(e => e.GuId).HasMaxLength(255);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2).HasMaxLength(255);

            //    entity.Property(e => e.Photo).HasMaxLength(255);

            //    entity.Property(e => e.PublishedTime).HasColumnType("datetime");

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.Property(e => e.Text2).HasColumnType("ntext");

            //    entity.Property(e => e.Url).HasMaxLength(255);

            //    entity.Property(e => e.Url2).HasMaxLength(255);

            //    entity.Property(e => e.Video).HasMaxLength(255);

            //    entity.HasOne(d => d.SurveyType)
            //        .WithMany(p => p.Survey)
            //        .HasForeignKey(d => d.SurveyTypeId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_survey_surveyTypeId");
            //});

            //modelBuilder.Entity<SurveyAccount>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.HasOne(d => d.Account)
            //        .WithMany(p => p.SurveyAccount)
            //        .HasForeignKey(d => d.AccountId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveyAccount_accountId");

            //    entity.HasOne(d => d.Survey)
            //        .WithMany(p => p.SurveyAccount)
            //        .HasForeignKey(d => d.SurveyId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveyAccount_surveyId");
            //});

            //modelBuilder.Entity<SurveyMeta>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Key)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Value)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.HasOne(d => d.Survey)
            //        .WithMany(p => p.SurveyMeta)
            //        .HasForeignKey(d => d.SurveyId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveyMeta_surveyId");
            //});

            //modelBuilder.Entity<SurveySection>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Description2).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2).HasMaxLength(255);

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.Property(e => e.Text2).HasColumnType("ntext");

            //    entity.HasOne(d => d.Survey)
            //        .WithMany(p => p.SurveySection)
            //        .HasForeignKey(d => d.SurveyId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveySection_surveyId");

            //    entity.HasOne(d => d.SurveySectionNavigation)
            //        .WithMany(p => p.InverseSurveySectionNavigation)
            //        .HasForeignKey(d => d.SurveySectionId)
            //        .HasConstraintName("FK_surveySection_surveySectionId");
            //});

            //modelBuilder.Entity<SurveySectionAccount>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.HasOne(d => d.SurveyAccount)
            //        .WithMany(p => p.SurveySectionAccount)
            //        .HasForeignKey(d => d.SurveyAccountId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveySectionAccount_surveyAccountId");
            //});

            //modelBuilder.Entity<SurveySectionAccountDetail>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.HasOne(d => d.Answer)
            //        .WithMany(p => p.SurveySectionAccountDetailAnswer)
            //        .HasForeignKey(d => d.AnswerId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveySectionAccountDetail_answerId");

            //    entity.HasOne(d => d.Question)
            //        .WithMany(p => p.SurveySectionAccountDetailQuestion)
            //        .HasForeignKey(d => d.QuestionId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveySectionAccountDetail_questionId");

            //    entity.HasOne(d => d.SurveySectionAccountNavigation)
            //        .WithMany(p => p.SurveySectionAccountDetail)
            //        .HasForeignKey(d => d.SurveySectionAccount)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveySectionAccountDetail_surveySectionAccount");
            //});

            //modelBuilder.Entity<SurveySectionQuestion>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.HasOne(d => d.Question)
            //        .WithMany(p => p.SurveySectionQuestion)
            //        .HasForeignKey(d => d.QuestionId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveySectionQuestion_questionId");

            //    entity.HasOne(d => d.SurveySection)
            //        .WithMany(p => p.SurveySectionQuestion)
            //        .HasForeignKey(d => d.SurveySectionId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_surveySectionQuestion_surveySectionId");
            //});



            //modelBuilder.Entity<Question>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Description2).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2).HasMaxLength(255);

            //    entity.Property(e => e.Photo).HasMaxLength(255);

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.Property(e => e.Text2).HasColumnType("ntext");

            //    entity.HasOne(d => d.QuestionType)
            //        .WithMany(p => p.Question)
            //        .HasForeignKey(d => d.QuestionTypeId)
            //        .HasConstraintName("FK_question_questionTypeId");
            //});

            //modelBuilder.Entity<QuestionType>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<EnterpriseType>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Description2).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2).HasMaxLength(255);

            //    entity.Property(e => e.Photo).HasMaxLength(255);

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.Property(e => e.Text2).HasColumnType("ntext");
            //});

            //modelBuilder.Entity<FinancialProduct>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Description2).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2).HasMaxLength(255);

            //    entity.Property(e => e.Photo).HasMaxLength(255);

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.Property(e => e.Text2).HasColumnType("ntext");

            //    entity.HasOne(d => d.FinancialProductType)
            //        .WithMany(p => p.FinancialProduct)
            //        .HasForeignKey(d => d.FinancialProductTypeId)
            //        .HasConstraintName("FK_financialProduct_financialProductTypeId");
            //});

            //modelBuilder.Entity<FinancialProductDetail>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Description2).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2).HasMaxLength(255);

            //    entity.Property(e => e.Photo).HasMaxLength(255);

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.Property(e => e.Text2).HasColumnType("ntext");

            //    entity.HasOne(d => d.EnterpriseType)
            //        .WithMany(p => p.FinancialProductDetail)
            //        .HasForeignKey(d => d.EnterpriseTypeId)
            //        .HasConstraintName("FK_financialProductDetail_enterpriseTypeId");

            //    entity.HasOne(d => d.FinancialProduct)
            //        .WithMany(p => p.FinancialProductDetail)
            //        .HasForeignKey(d => d.FinancialProductId)
            //        .HasConstraintName("FK_financialProductDetail_financialProductId");

            //    entity.HasOne(d => d.OrganizationType)
            //        .WithMany(p => p.FinancialProductDetail)
            //        .HasForeignKey(d => d.OrganizationTypeId)
            //        .HasConstraintName("FK_financialProductDetail_organizationTypeId");
            //});

            //modelBuilder.Entity<FinancialProductType>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<Organization>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Description2).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2).HasMaxLength(255);

            //    entity.Property(e => e.Photo).HasMaxLength(255);

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.Property(e => e.Text2).HasColumnType("ntext");

            //    entity.HasOne(d => d.OrganizationType)
            //        .WithMany(p => p.Organization)
            //        .HasForeignKey(d => d.OrganizationTypeId)
            //        .HasConstraintName("FK_organization_organizationTypeId");
            //});

            //modelBuilder.Entity<OrganizationType>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});

            //modelBuilder.Entity<PreferentialProduct>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Description2).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2).HasMaxLength(255);

            //    entity.Property(e => e.Photo).HasMaxLength(255);

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.Property(e => e.Text2).HasColumnType("ntext");

            //    entity.HasOne(d => d.PreferentialType)
            //        .WithMany(p => p.PreferentialProduct)
            //        .HasForeignKey(d => d.PreferentialTypeId)
            //        .HasConstraintName("FK__Preferent__Prefe__489AC854");
            //});

            //modelBuilder.Entity<PreferentialProductDetail>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Description2).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);

            //    entity.Property(e => e.Name2).HasMaxLength(255);

            //    entity.Property(e => e.Photo).HasMaxLength(255);

            //    entity.Property(e => e.Text).HasColumnType("ntext");

            //    entity.Property(e => e.Text2).HasColumnType("ntext");

            //    entity.HasOne(d => d.Organization)
            //        .WithMany(p => p.PreferentialProductDetail)
            //        .HasForeignKey(d => d.OrganizationId)
            //        .HasConstraintName("FK_preferentialProductDetail_organizationId");

            //    entity.HasOne(d => d.PreferentialProduct)
            //        .WithMany(p => p.PreferentialProductDetail)
            //        .HasForeignKey(d => d.PreferentialProductId)
            //        .HasConstraintName("FK_preferentialProductDetail_preferentialProductId");
            //});

            //modelBuilder.Entity<PreferentialType>(entity =>
            //{
            //    entity.Property(e => e.CreatedTime)
            //        .HasColumnType("datetime")
            //        .HasDefaultValueSql("(getdate())");

            //    entity.Property(e => e.Description).HasColumnType("ntext");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(255);
            //});
        }
    }
}
