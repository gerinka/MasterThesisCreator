﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 5/29/2016 1:39:55 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace MtcModel
{

    /// <summary>
    /// There are no comments for MtcModel.USER in the schema.
    /// </summary>
    public partial class USER    {

        public USER()
        {
            OnCreated();
        }


        #region Properties
    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        public virtual int Id
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for FirstName in the schema.
        /// </summary>
        public virtual string FirstName
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for MiddleName in the schema.
        /// </summary>
        public virtual string MiddleName
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for FamilyName in the schema.
        /// </summary>
        public virtual string FamilyName
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for UserName in the schema.
        /// </summary>
        public virtual string UserName
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Email in the schema.
        /// </summary>
        public virtual string Email
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Password in the schema.
        /// </summary>
        public virtual string Password
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for ExperiencePoints in the schema.
        /// </summary>
        public virtual global::System.Nullable<int> ExperiencePoints
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Level in the schema.
        /// </summary>
        public virtual global::System.Nullable<short> Level
        {
            get;
            set;
        }


        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for DOCUMENTs_MentorId in the schema.
        /// </summary>
        public virtual ICollection<DOCUMENT> DOCUMENTs_MentorId
        {
            get;
            set;
        }
    
        /// <summary>
        /// There are no comments for DOCUMENTs_UserId in the schema.
        /// </summary>
        public virtual ICollection<DOCUMENT> DOCUMENTs_UserId
        {
            get;
            set;
        }
    
        /// <summary>
        /// There are no comments for TASKs in the schema.
        /// </summary>
        public virtual ICollection<TASK> TASKs
        {
            get;
            set;
        }

        #endregion
    
        #region Extensibility Method Definitions
        partial void OnCreated();
        #endregion
    }

}
