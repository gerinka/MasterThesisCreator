﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 5/22/2016 9:34:47 AM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;

namespace MtcModel
{
    public partial class MtcEntities : DbContext
    {
        #region Constructors

        /// <summary>
        /// Initialize a new MtcEntities object.
        /// </summary>
        public MtcEntities() :
                base(@"name=MTCEntitiesConnectionString")
        {
            Configure();
        }

        /// <summary>
        /// Initializes a new MtcEntities object using the connection string found in the 'MtcEntities' section of the application configuration file.
        /// </summary>
        public MtcEntities(string nameOrConnectionString) :
                base(nameOrConnectionString)
        {
            Configure();
        }

        /// <summary>
        /// Initialize a new MtcEntities object.
        /// </summary>
        public MtcEntities(DbConnection existingConnection, bool contextOwnsConnection) :
                base(existingConnection, contextOwnsConnection)
        {
            Configure();
        }

        /// <summary>
        /// Initialize a new MtcEntities object.
        /// </summary>
        public MtcEntities(ObjectContext objectContext, bool dbContextOwnsObjectContext) :
                base(objectContext, dbContextOwnsObjectContext)
        {
            Configure();
        }

        /// <summary>
        /// Initialize a new MtcEntities object.
        /// </summary>
        public MtcEntities(string nameOrConnectionString, DbCompiledModel model) :
                base(nameOrConnectionString, model)
        {
            Configure();
        }

        /// <summary>
        /// Initialize a new MtcEntities object.
        /// </summary>
        public MtcEntities(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) :
                base(existingConnection, model, contextOwnsConnection)
        {
            Configure();
        }

        private void Configure()
        {
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.ValidateOnSaveEnabled = true;
        }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            #region DOCUMENT

            modelBuilder.Entity<DOCUMENT>()
                .HasKey(p => new { p.ID })
                .ToTable("document", "mtc");
            // Properties:
            modelBuilder.Entity<DOCUMENT>()
                .Property(p => p.ID)
                    .IsRequired()
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<DOCUMENT>()
                .Property(p => p.UserId)
                    .IsRequired();
            modelBuilder.Entity<DOCUMENT>()
                .Property(p => p.Deadline)
                    .IsRequired();
            modelBuilder.Entity<DOCUMENT>()
                .Property(p => p.Title)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            modelBuilder.Entity<DOCUMENT>()
                .Property(p => p.CurrentProgress)
                    .IsRequired();
            modelBuilder.Entity<DOCUMENT>()
                .Property(p => p.MentorId);
            modelBuilder.Entity<DOCUMENT>()
                .Property(p => p.DocumentTemplateId)
                    .IsRequired();
            modelBuilder.Entity<DOCUMENT>()
                .Property(p => p.DocumentState)
                    .IsRequired();
            // Associations:
            modelBuilder.Entity<DOCUMENT>()
                .HasMany(p => p.REFERENCEs)
                    .WithRequired(c => c.DOCUMENT)
                .HasForeignKey(p => new { p.DocumentId })
                    .WillCascadeOnDelete(false);
            modelBuilder.Entity<DOCUMENT>()
                .HasMany(p => p.STRUCTURECONTENTs)
                    .WithRequired(c => c.DOCUMENT)
                .HasForeignKey(p => new { p.DocumentId })
                    .WillCascadeOnDelete(false);
            modelBuilder.Entity<DOCUMENT>()
                .HasMany(p => p.TASKs)
                    .WithRequired(c => c.DOCUMENT)
                .HasForeignKey(p => new { p.DocumentId })
                    .WillCascadeOnDelete(false);

            #endregion

            #region DOCUMENTTEMPLATE

            modelBuilder.Entity<DOCUMENTTEMPLATE>()
                .HasKey(p => new { p.Id })
                .ToTable("documenttemplate", "mtc");
            // Properties:
            modelBuilder.Entity<DOCUMENTTEMPLATE>()
                .Property(p => p.Id)
                    .IsRequired()
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<DOCUMENTTEMPLATE>()
                .Property(p => p.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            modelBuilder.Entity<DOCUMENTTEMPLATE>()
                .Property(p => p.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            modelBuilder.Entity<DOCUMENTTEMPLATE>()
                .Property(p => p.IsActive)
                    .IsRequired();
            // Associations:
            modelBuilder.Entity<DOCUMENTTEMPLATE>()
                .HasMany(p => p.DOCUMENTs)
                    .WithRequired(c => c.DOCUMENTTEMPLATE)
                .HasForeignKey(p => new { p.DocumentTemplateId })
                    .WillCascadeOnDelete(false);
            modelBuilder.Entity<DOCUMENTTEMPLATE>()
                .HasMany(p => p.STRUCTUREELEMENTs)
                    .WithMany(c => c.DOCUMENTTEMPLATEs)
                .Map(manyToMany => manyToMany
                    .ToTable("documentstructurerelation", "mtc")
                    .MapLeftKey("DocumentTemplateId")
                    .MapRightKey("StructureElementId"));

            #endregion

            #region REFERENCE

            modelBuilder.Entity<REFERENCE>()
                .HasKey(p => new { p.Id })
                .ToTable("reference", "mtc");
            // Properties:
            modelBuilder.Entity<REFERENCE>()
                .Property(p => p.Id)
                    .IsRequired()
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<REFERENCE>()
                .Property(p => p.ReferenceTypeId);
            modelBuilder.Entity<REFERENCE>()
                .Property(p => p.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            modelBuilder.Entity<REFERENCE>()
                .Property(p => p.Order);
            modelBuilder.Entity<REFERENCE>()
                .Property(p => p.DocumentId)
                    .IsRequired();

            #endregion

            #region STRUCTURECONTENT

            modelBuilder.Entity<STRUCTURECONTENT>()
                .HasKey(p => new { p.Id })
                .ToTable("structurecontent", "mtc");
            // Properties:
            modelBuilder.Entity<STRUCTURECONTENT>()
                .Property(p => p.Id)
                    .IsRequired()
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<STRUCTURECONTENT>()
                .Property(p => p.StructureElementId)
                    .IsRequired();
            modelBuilder.Entity<STRUCTURECONTENT>()
                .Property(p => p.Title)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            modelBuilder.Entity<STRUCTURECONTENT>()
                .Property(p => p.Content);
            modelBuilder.Entity<STRUCTURECONTENT>()
                .Property(p => p.DocumentId)
                    .IsRequired();
            modelBuilder.Entity<STRUCTURECONTENT>()
                .Property(p => p.Order)
                    .IsRequired();
            modelBuilder.Entity<STRUCTURECONTENT>()
                .Property(p => p.CurrentProgress);
            // Association:
            modelBuilder.Entity<STRUCTURECONTENT>()
                .HasMany(p => p.TASKs)
                    .WithOptional(c => c.STRUCTURECONTENT)
                .HasForeignKey(p => new { p.StrucktureContentId })
                    .WillCascadeOnDelete(false);

            #endregion

            #region STRUCTUREELEMENT

            modelBuilder.Entity<STRUCTUREELEMENT>()
                .HasKey(p => new { p.Id })
                .ToTable("structureelement", "mtc");
            // Properties:
            modelBuilder.Entity<STRUCTUREELEMENT>()
                .Property(p => p.Id)
                    .IsRequired()
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<STRUCTUREELEMENT>()
                .Property(p => p.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            modelBuilder.Entity<STRUCTUREELEMENT>()
                .Property(p => p.StructureTypeId)
                    .IsRequired();
            modelBuilder.Entity<STRUCTUREELEMENT>()
                .Property(p => p.Description)
                    .HasMaxLength(455)
                    .IsUnicode(false);
            modelBuilder.Entity<STRUCTUREELEMENT>()
                .Property(p => p.Order);
            // Associations:
            modelBuilder.Entity<STRUCTUREELEMENT>()
                .HasMany(p => p.STRUCTURECONTENTs)
                    .WithRequired(c => c.STRUCTUREELEMENT)
                .HasForeignKey(p => new { p.StructureElementId })
                    .WillCascadeOnDelete(false);
            modelBuilder.Entity<STRUCTUREELEMENT>()
                .HasMany(p => p.PARENTSTRUCTUREELEMENTS)
                    .WithMany(c => c.CHILDSTRUCTUREELEMENTS)
                .Map(manyToMany => manyToMany
                    .ToTable("structurerelation", "mtc")
                    .MapLeftKey("StructureElementChildId")
                    .MapRightKey("StructureElementParentId"));

            #endregion

            #region TASK

            modelBuilder.Entity<TASK>()
                .HasKey(p => new { p.Id })
                .ToTable("task", "mtc");
            // Properties:
            modelBuilder.Entity<TASK>()
                .Property(p => p.Id)
                    .IsRequired()
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<TASK>()
                .Property(p => p.Title)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            modelBuilder.Entity<TASK>()
                .Property(p => p.AssignTo);
            modelBuilder.Entity<TASK>()
                .Property(p => p.TaskState)
                    .IsRequired();
            modelBuilder.Entity<TASK>()
                .Property(p => p.Deadline)
                    .IsRequired();
            modelBuilder.Entity<TASK>()
                .Property(p => p.DocumentId)
                    .IsRequired();
            modelBuilder.Entity<TASK>()
                .Property(p => p.Order);
            modelBuilder.Entity<TASK>()
                .Property(p => p.TaskType)
                    .IsRequired();
            modelBuilder.Entity<TASK>()
                .Property(p => p.IsLocked)
                    .IsRequired();
            modelBuilder.Entity<TASK>()
                .Property(p => p.StrucktureContentId);

            #endregion

            #region USER

            modelBuilder.Entity<USER>()
                .HasKey(p => new { p.Id })
                .ToTable("user", "mtc");
            // Properties:
            modelBuilder.Entity<USER>()
                .Property(p => p.Id)
                    .IsRequired()
                    .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<USER>()
                .Property(p => p.FirstName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            modelBuilder.Entity<USER>()
                .Property(p => p.MiddleName)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            modelBuilder.Entity<USER>()
                .Property(p => p.FamilyName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            modelBuilder.Entity<USER>()
                .Property(p => p.UserName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            modelBuilder.Entity<USER>()
                .Property(p => p.Email)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            modelBuilder.Entity<USER>()
                .Property(p => p.Password)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            modelBuilder.Entity<USER>()
                .Property(p => p.ExperiencePoints);
            modelBuilder.Entity<USER>()
                .Property(p => p.Level);
            // Associations:
            modelBuilder.Entity<USER>()
                .HasMany(p => p.DOCUMENTs_MentorId)
                    .WithOptional(c => c.USER_MentorId)
                .HasForeignKey(p => new { p.MentorId })
                    .WillCascadeOnDelete(false);
            modelBuilder.Entity<USER>()
                .HasMany(p => p.DOCUMENTs_UserId)
                    .WithRequired(c => c.USER_UserId)
                .HasForeignKey(p => new { p.UserId })
                    .WillCascadeOnDelete(false);
            modelBuilder.Entity<USER>()
                .HasMany(p => p.TASKs)
                    .WithOptional(c => c.USER)
                .HasForeignKey(p => new { p.AssignTo })
                    .WillCascadeOnDelete(false);

            #endregion

            #region Disabled conventions


            #endregion

        }

    
        /// <summary>
        /// There are no comments for DOCUMENT in the schema.
        /// </summary>
        public virtual DbSet<DOCUMENT> DOCUMENTs { get; set; }
    
        /// <summary>
        /// There are no comments for DOCUMENTTEMPLATE in the schema.
        /// </summary>
        public virtual DbSet<DOCUMENTTEMPLATE> DOCUMENTTEMPLATEs { get; set; }
    
        /// <summary>
        /// There are no comments for REFERENCE in the schema.
        /// </summary>
        public virtual DbSet<REFERENCE> REFERENCEs { get; set; }
    
        /// <summary>
        /// There are no comments for STRUCTURECONTENT in the schema.
        /// </summary>
        public virtual DbSet<STRUCTURECONTENT> STRUCTURECONTENTs { get; set; }
    
        /// <summary>
        /// There are no comments for STRUCTUREELEMENT in the schema.
        /// </summary>
        public virtual DbSet<STRUCTUREELEMENT> STRUCTUREELEMENTs { get; set; }
    
        /// <summary>
        /// There are no comments for TASK in the schema.
        /// </summary>
        public virtual DbSet<TASK> TASKs { get; set; }
    
        /// <summary>
        /// There are no comments for USER in the schema.
        /// </summary>
        public virtual DbSet<USER> USERs { get; set; }
    }
}
