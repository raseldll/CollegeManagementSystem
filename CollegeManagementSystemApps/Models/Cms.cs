namespace CollegeManagementSystemApps.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Cms : DbContext
    {
        public Cms()
            : base("name=cmsconnection")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<admission_form> admission_form { get; set; }
        public virtual DbSet<admission_student_address> admission_student_address { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<district> districts { get; set; }
        public virtual DbSet<division> divisions { get; set; }
        public virtual DbSet<exam_type> exam_type { get; set; }
        public virtual DbSet<group_name> group_name { get; set; }
        public virtual DbSet<result> results { get; set; }
        public virtual DbSet<student_department> student_department { get; set; }
        public virtual DbSet<student_info> student_info { get; set; }
        public virtual DbSet<student_religion> student_religion { get; set; }
        public virtual DbSet<student_selected_subject> student_selected_subject { get; set; }
        public virtual DbSet<sub_district> sub_district { get; set; }
        public virtual DbSet<subject> subjects { get; set; }
        public virtual DbSet<subject_category> subject_category { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<teacher> teachers { get; set; }
        public virtual DbSet<teacher_group> teacher_group { get; set; }
        public virtual DbSet<test> tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<admission_form>()
                .Property(e => e.student_full_name)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.student_father_name)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.student_mother_name)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.father_education)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.mohter_education)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.father_profession)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.student_refarence)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.student_blood_group)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.student_nationality)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.student_exam_name)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.student_school_name)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.student_email)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.student_image)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.student_ssc_roll)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.student_ssc_registration_no)
                .IsUnicode(false);

            modelBuilder.Entity<admission_form>()
                .Property(e => e.student_admission_password)
                .IsUnicode(false);

            modelBuilder.Entity<admission_student_address>()
                .Property(e => e.parmanent_village)
                .IsUnicode(false);

            modelBuilder.Entity<admission_student_address>()
                .Property(e => e.parmanent_post)
                .IsUnicode(false);

            modelBuilder.Entity<admission_student_address>()
                .Property(e => e.parmanent_post_code)
                .IsUnicode(false);

            modelBuilder.Entity<admission_student_address>()
                .Property(e => e.present_village)
                .IsUnicode(false);

            modelBuilder.Entity<admission_student_address>()
                .Property(e => e.present_post)
                .IsUnicode(false);

            modelBuilder.Entity<admission_student_address>()
                .Property(e => e.present_post_code)
                .IsUnicode(false);

            modelBuilder.Entity<admission_student_address>()
                .Property(e => e.mobile_number)
                .IsUnicode(false);

            modelBuilder.Entity<admission_student_address>()
                .HasMany(e => e.admission_form)
                .WithRequired(e => e.admission_student_address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<district>()
                .Property(e => e.district_name)
                .IsUnicode(false);

            modelBuilder.Entity<district>()
                .HasMany(e => e.sub_district)
                .WithRequired(e => e.district)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<division>()
                .Property(e => e.division_name)
                .IsUnicode(false);

            modelBuilder.Entity<division>()
                .HasMany(e => e.districts)
                .WithRequired(e => e.division)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<exam_type>()
                .Property(e => e.exam_type_name)
                .IsUnicode(false);

            modelBuilder.Entity<exam_type>()
                .HasMany(e => e.results)
                .WithRequired(e => e.exam_type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<group_name>()
                .Property(e => e.group_name1)
                .IsUnicode(false);

            modelBuilder.Entity<group_name>()
                .HasMany(e => e.subject_category)
                .WithRequired(e => e.group_name)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<student_department>()
                .Property(e => e.student_department_name)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.student_full_name)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.student_father_name)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.student_mother_name)
                .IsFixedLength();

            modelBuilder.Entity<student_info>()
                .Property(e => e.student_father_mobile_number)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.student_address)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.student_mobile_number)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.student_email)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.student_image)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.student_session)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.student_hsc_roll)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .Property(e => e.student_hsc_registration_no)
                .IsUnicode(false);

            modelBuilder.Entity<student_info>()
                .HasMany(e => e.results)
                .WithRequired(e => e.student_info)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<student_religion>()
                .Property(e => e.student_religion_name)
                .IsUnicode(false);

            modelBuilder.Entity<student_religion>()
                .HasMany(e => e.admission_form)
                .WithRequired(e => e.student_religion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<student_selected_subject>()
                .HasMany(e => e.results)
                .WithRequired(e => e.student_selected_subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sub_district>()
                .Property(e => e.sub_district_name)
                .IsUnicode(false);

            modelBuilder.Entity<sub_district>()
                .HasMany(e => e.admission_student_address)
                .WithRequired(e => e.sub_district)
                .HasForeignKey(e => e.parmanent_sub_district_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sub_district>()
                .HasMany(e => e.admission_student_address1)
                .WithRequired(e => e.sub_district1)
                .HasForeignKey(e => e.present_sub_district_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<subject>()
                .Property(e => e.subject_name)
                .IsUnicode(false);

            modelBuilder.Entity<subject>()
                .HasMany(e => e.student_selected_subject)
                .WithRequired(e => e.subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<subject_category>()
                .Property(e => e.subject_category_name)
                .IsUnicode(false);

            modelBuilder.Entity<subject_category>()
                .HasMany(e => e.subjects)
                .WithRequired(e => e.subject_category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.teacher_full_name)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.teacher_degination)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.teacher_eduaction)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.teacher_image)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.teacher_address)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.teacher_mobile_number)
                .IsUnicode(false);

            modelBuilder.Entity<teacher>()
                .Property(e => e.teacher_email)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_group>()
                .Property(e => e.teacher_group_name)
                .IsUnicode(false);

            modelBuilder.Entity<teacher_group>()
                .HasMany(e => e.teachers)
                .WithRequired(e => e.teacher_group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<test>()
                .Property(e => e.test_name)
                .IsUnicode(false);
        }
    }
}
