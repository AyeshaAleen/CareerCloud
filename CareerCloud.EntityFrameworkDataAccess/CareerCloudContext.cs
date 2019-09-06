using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class CareerCloudContext : DbContext
    {
        public CareerCloudContext() : base(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantProfilePoco>()
            .HasMany(a => a.ApplicantEducations).WithRequired(e => e.ApplicantProfiles)
            .HasForeignKey(e => e.Applicant).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicantProfilePoco>()
            .HasMany(a => a.ApplicantJobApplications).WithRequired(e => e.ApplicantProfiles)
            .HasForeignKey(e => e.Applicant).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicantProfilePoco>()
            .HasMany(a => a.ApplicantResumes).WithRequired(e => e.ApplicantProfiles)
            .HasForeignKey(e => e.Applicant).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicantProfilePoco>()
            .HasMany(a => a.ApplicantSkills).WithRequired(e => e.ApplicantProfiles)
            .HasForeignKey(e => e.Applicant).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicantProfilePoco>()
            .HasMany(a => a.ApplicantWorkHistory).WithRequired(e => e.ApplicantProfiles)
            .HasForeignKey(e => e.Applicant).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CompanyJobPoco>()
            .HasMany(a => a.ApplicantJobApplications).WithRequired(e => e.CompanyJobs)
            .HasForeignKey(e => e.Job).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CompanyJobPoco>()
            .HasMany(a => a.CompanyJobDescriptions).WithRequired(e => e.CompanyJobs)
            .HasForeignKey(e => e.Job).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CompanyJobPoco>()
            .HasMany(a => a.CompanyJobSkills).WithRequired(e => e.CompanyJobs)
            .HasForeignKey(e => e.Job).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CompanyJobPoco>()
            .HasMany(a => a.CompanyJobEducations).WithRequired(e => e.CompanyJobs)
            .HasForeignKey(e => e.Job).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CompanyProfilePoco>()
            .HasMany(c => c.CompanyDescriptions).WithRequired(d => d.CompanyProfiles)
            .HasForeignKey(d => d.Company).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CompanyProfilePoco>()
            .HasMany(c => c.CompanyLocations).WithRequired(d => d.CompanyProfiles)
            .HasForeignKey(d => d.Company).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CompanyProfilePoco>()
            .HasMany(c => c.CompanyJobs).WithRequired(d => d.CompanyProfiles)
            .HasForeignKey(d => d.Company).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SecurityLoginPoco>()
            .HasMany(c => c.ApplicantProfiles).WithRequired(d => d.SecurityLogins)
            .HasForeignKey(d => d.Login).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SecurityLoginPoco>()
            .HasMany(c => c.SecurityLoginsLogs).WithRequired(d => d.SecurityLogin)
            .HasForeignKey(d => d.Login).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SecurityLoginPoco>()
            .HasMany(c => c.SecurityLoginsRoles).WithRequired(d => d.SecurityLogin)
            .HasForeignKey(d => d.Login).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SecurityRolePoco>()
            .HasMany(c => c.SecurityLoginsRoles).WithRequired(d => d.SecurityRole)
            .HasForeignKey(d => d.Role).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SystemCountryCodePoco>()
            .HasMany(c => c.ApplicantProfile).WithRequired(d => d.SystemCountryCode)
            .HasForeignKey(d => d.Country).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SystemCountryCodePoco>()
            .HasMany(c => c.ApplicantWorkHistory).WithRequired(d => d.SystemCountryCode)
            .HasForeignKey(d => d.CountryCode).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SystemLanguageCodePoco>()
            .HasMany(c => c.CompanyDescriptions).WithRequired(d => d.SystemLanguageCodes)
            .HasForeignKey(d => d.LanguageId).WillCascadeOnDelete(true);
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<ApplicantEducationPoco>().Ignore(o => o.TimeStamp);

            modelBuilder.Entity<ApplicantJobApplicationPoco>().Ignore(o => o.TimeStamp);

            modelBuilder.Entity<ApplicantProfilePoco>().Ignore(o => o.TimeStamp);

            modelBuilder.Entity<ApplicantSkillPoco>().Ignore(o => o.TimeStamp);

            modelBuilder.Entity<ApplicantWorkHistoryPoco>().Ignore(o => o.TimeStamp);

            modelBuilder.Entity<CompanyDescriptionPoco>().Ignore(o => o.TimeStamp);

            modelBuilder.Entity<CompanyJobSkillPoco>().Ignore(o => o.TimeStamp);

            modelBuilder.Entity<CompanyJobPoco>().Ignore(o => o.TimeStamp);

            modelBuilder.Entity<CompanyJobEducationPoco>().Ignore(o => o.TimeStamp);

            modelBuilder.Entity<CompanyJobDescriptionPoco>().Ignore(o => o.TimeStamp);

            modelBuilder.Entity<CompanyLocationPoco>().Ignore(o => o.TimeStamp);

            modelBuilder.Entity<CompanyProfilePoco>().Ignore(o => o.TimeStamp);

            modelBuilder.Entity<SecurityLoginPoco>().Ignore(o => o.TimeStamp);

            modelBuilder.Entity<SecurityLoginsRolePoco>().Ignore(o => o.TimeStamp);



        }

        DbSet<CompanyDescriptionPoco> companyDescriptions { get; set; }
        DbSet<ApplicantEducationPoco> applicantEducations { get; set; }
        DbSet<ApplicantJobApplicationPoco> applicantJobApplications { get; set; }
        DbSet<ApplicantProfilePoco> applicantProfiles { get; set; }
        DbSet<ApplicantResumePoco> applicantResumes { get; set; }
        DbSet<ApplicantSkillPoco> applicantSkills { get; set; }
        DbSet<ApplicantWorkHistoryPoco> applicantWorkHistory { get; set; }
        DbSet<CompanyJobDescriptionPoco> companyJobDescriptions { get; set;}
        DbSet<CompanyJobEducationPoco> companyJobEducations { get; set; }
        DbSet<CompanyJobPoco> companyJobs { get; set; }
        DbSet<CompanyJobSkillPoco> companyJobSkill { get; set; }
        DbSet<CompanyLocationPoco> companyLocations { get; set; }
        DbSet<SecurityLoginPoco> securityLogins { get; set; }
        DbSet<SecurityLoginsLogPoco> securityLoginsLogs { get; set; }
        DbSet<SecurityLoginsRolePoco> securityLoginsRoles { get; set; }
        DbSet<SystemCountryCodePoco> systemCountryCodes { get; set; }
        DbSet<SystemLanguageCodePoco> systemLanguageCodes { get; set; }



    }
}
