﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest1Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("01ca0f7c-ce5f-4b99-bca9-d07ae46931cd")]
    public partial class MyTest1Repository : RepoGenBaseFolder
    {
        static MyTest1Repository instance = new MyTest1Repository();
        MyTest1RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest1Repository element repository.
        /// </summary>
        [RepositoryFolder("01ca0f7c-ce5f-4b99-bca9-d07ae46931cd")]
        public static MyTest1Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest1Repository() 
            : base("MyTest1Repository", "/", null, 0, false, "01ca0f7c-ce5f-4b99-bca9-d07ae46931cd", ".\\RepositoryImages\\MyTest1Repository01ca0f7c.rximgres")
        {
            _applicationundertest = new MyTest1RepositoryFolders.ApplicationUnderTestAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("01ca0f7c-ce5f-4b99-bca9-d07ae46931cd")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("fb88b718-6a73-496b-a2cd-f31af07d951c")]
        public virtual MyTest1RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest1RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("fb88b718-6a73-496b-a2cd-f31af07d951c")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, false, "fb88b718-6a73-496b-a2cd-f31af07d951c", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("fb88b718-6a73-496b-a2cd-f31af07d951c")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("fb88b718-6a73-496b-a2cd-f31af07d951c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
