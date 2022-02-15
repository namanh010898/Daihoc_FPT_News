using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Daihoc_FPT_News.Model
{
    public partial class SWP391_DBContext : DbContext
    {
        public SWP391_DBContext()
        {
        }

        public SWP391_DBContext(DbContextOptions<SWP391_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<EventRequest> EventRequests { get; set; }
        public virtual DbSet<EventRequestStatus> EventRequestStatuses { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<PostCategory> PostCategories { get; set; }
        public virtual DbSet<PostLayout> PostLayouts { get; set; }
        public virtual DbSet<PostTag> PostTags { get; set; }
        public virtual DbSet<PostTopic> PostTopics { get; set; }
        public virtual DbSet<PostType> PostTypes { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionType> QuestionTypes { get; set; }
        public virtual DbSet<Recomment> Recomments { get; set; }
        public virtual DbSet<Subcribe> Subcribes { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<SurveyAccount> SurveyAccounts { get; set; }
        public virtual DbSet<SurveySection> SurveySections { get; set; }
        public virtual DbSet<SurveySectionAccount> SurveySectionAccounts { get; set; }
        public virtual DbSet<SurveySectionAccountDetail> SurveySectionAccountDetails { get; set; }
        public virtual DbSet<SurveySectionQuestion> SurveySectionQuestions { get; set; }
        public virtual DbSet<SurveyType> SurveyTypes { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<ViewStatus> ViewStatuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=localhost;database=SWP391_DB;uid=test1;pwd=12345678");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountTypeId).HasColumnName("AccountTypeID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Info)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.Photo).HasColumnType("ntext");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.ToTable("AccountType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Answer>(entity =>
            {
                entity.ToTable("Answer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Answers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Answer_Question");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Email).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.Property(e => e.Website).HasColumnType("ntext");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Contact");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Account)
                    .WithMany()
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contact_Account");
            });

            modelBuilder.Entity<EventRequest>(entity =>
            {
                entity.ToTable("EventRequest");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.EventRequests)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventRequest_Account");

                entity.HasOne(d => d.EventRequestStatus)
                    .WithMany(p => p.EventRequests)
                    .HasForeignKey(d => d.EventRequestStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventRequest_EventRequestStatus");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.EventRequests)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventRequest_Post");
            });

            modelBuilder.Entity<EventRequestStatus>(entity =>
            {
                entity.ToTable("EventRequestStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("Notification");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClosedTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.EventAddress).HasColumnType("ntext");

                entity.Property(e => e.FileUrl)
                    .HasColumnType("ntext")
                    .HasColumnName("FileURL");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OpenTime).HasColumnType("datetime");

                entity.Property(e => e.Photo)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PostAccountId).HasColumnName("PostAccountID");

                entity.Property(e => e.PostCategoryId).HasColumnName("PostCategoryID");

                entity.Property(e => e.PostCommentStatusId).HasColumnName("PostCommentStatusID");

                entity.Property(e => e.PostLayoutId).HasColumnName("PostLayoutID");

                entity.Property(e => e.PostPublishStatusId).HasColumnName("PostPublishStatusID");

                entity.Property(e => e.PostTypeId).HasColumnName("PostTypeID");

                entity.Property(e => e.PublishedTime).HasColumnType("datetime");

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.Property(e => e.Url).HasMaxLength(255);

                entity.Property(e => e.Video).HasMaxLength(255);
            });

            modelBuilder.Entity<PostCategory>(entity =>
            {
                entity.ToTable("PostCategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Photo).HasMaxLength(255);

                entity.Property(e => e.Slug).HasMaxLength(255);
            });

            modelBuilder.Entity<PostLayout>(entity =>
            {
                entity.ToTable("PostLayout");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PostTag>(entity =>
            {
                entity.ToTable("PostTag");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.PostTags)
                    .HasForeignKey(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PostTag_Tag");
            });

            modelBuilder.Entity<PostTopic>(entity =>
            {
                entity.ToTable("PostTopic");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");
            });

            modelBuilder.Entity<PostType>(entity =>
            {
                entity.ToTable("PostType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.ToTable("Question");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Photo).HasMaxLength(255);

                entity.Property(e => e.QuestionTypeId).HasColumnName("QuestionTypeID");

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.HasOne(d => d.QuestionType)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.QuestionTypeId)
                    .HasConstraintName("FK_Question_QuestionType");
            });

            modelBuilder.Entity<QuestionType>(entity =>
            {
                entity.ToTable("QuestionType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Recomment>(entity =>
            {
                entity.ToTable("Recomment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.SurveySectionId).HasColumnName("SurveySectionID");

                entity.HasOne(d => d.SurveySection)
                    .WithMany(p => p.Recomments)
                    .HasForeignKey(d => d.SurveySectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Recomment_SurveySection");
            });

            modelBuilder.Entity<Subcribe>(entity =>
            {
                entity.ToTable("Subcribe");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Survey>(entity =>
            {
                entity.ToTable("Survey");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PublishedTime).HasColumnType("datetime");

                entity.Property(e => e.SurveyTypeId).HasColumnName("SurveyTypeID");

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.HasOne(d => d.SurveyType)
                    .WithMany(p => p.Surveys)
                    .HasForeignKey(d => d.SurveyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Survey_SurveyType");
            });

            modelBuilder.Entity<SurveyAccount>(entity =>
            {
                entity.ToTable("SurveyAccount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveyAccounts)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveyAccount_Survey");
            });

            modelBuilder.Entity<SurveySection>(entity =>
            {
                entity.ToTable("SurveySection");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SurveyId).HasColumnName("SurveyID");

                entity.Property(e => e.SurveySectionId).HasColumnName("SurveySectionID");

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.HasOne(d => d.Survey)
                    .WithMany(p => p.SurveySections)
                    .HasForeignKey(d => d.SurveyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveySection_Survey");
            });

            modelBuilder.Entity<SurveySectionAccount>(entity =>
            {
                entity.ToTable("SurveySectionAccount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SurveyAccountId).HasColumnName("SurveyAccountID");

                entity.HasOne(d => d.SurveyAccount)
                    .WithMany(p => p.SurveySectionAccounts)
                    .HasForeignKey(d => d.SurveyAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveySectionAccount_SurveyAccount");
            });

            modelBuilder.Entity<SurveySectionAccountDetail>(entity =>
            {
                entity.ToTable("SurveySectionAccountDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.SurveySectionAccountDetails)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveySectionAccountDetail_Question");

                entity.HasOne(d => d.SurveySectionAccountNavigation)
                    .WithMany(p => p.SurveySectionAccountDetails)
                    .HasForeignKey(d => d.SurveySectionAccount)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveySectionAccountDetail_SurveyAccount");
            });

            modelBuilder.Entity<SurveySectionQuestion>(entity =>
            {
                entity.ToTable("SurveySectionQuestion");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.SurveySectionId).HasColumnName("SurveySectionID");

                entity.Property(e => e.Text).HasColumnType("ntext");

                entity.HasOne(d => d.SurveySection)
                    .WithMany(p => p.SurveySectionQuestions)
                    .HasForeignKey(d => d.SurveySectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurveySectionQuestion_SurveySection");
            });

            modelBuilder.Entity<SurveyType>(entity =>
            {
                entity.ToTable("SurveyType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("Tag");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ViewStatus>(entity =>
            {
                entity.ToTable("ViewStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
