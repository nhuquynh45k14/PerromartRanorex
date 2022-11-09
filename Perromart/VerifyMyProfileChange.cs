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
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Perromart
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerifyMyProfileChange recording.
    /// </summary>
    [TestModule("3d09cd82-a9e8-4546-880c-979e8d6192b6", ModuleType.Recording, 1)]
    public partial class VerifyMyProfileChange : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PerromartRepository repository.
        /// </summary>
        public static PerromartRepository repo = PerromartRepository.Instance;

        static VerifyMyProfileChange instance = new VerifyMyProfileChange();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyMyProfileChange()
        {
            Name = "";
            UserName = "";
            ProfileImage = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyMyProfileChange Instance
        {
            get { return instance; }
        }

#region Variables

        string _Name;

        /// <summary>
        /// Gets or sets the value of variable Name.
        /// </summary>
        [TestVariable("4f476b9c-5de8-4e24-9e9a-e0d5e6f75b02")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        string _UserName;

        /// <summary>
        /// Gets or sets the value of variable UserName.
        /// </summary>
        [TestVariable("a6511b54-3990-4a93-b014-4fbc95fb63ba")]
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        string _ProfileImage;

        /// <summary>
        /// Gets or sets the value of variable ProfileImage.
        /// </summary>
        [TestVariable("924e9ef3-d26b-430b-98dc-424626bd52bf")]
        public string ProfileImage
        {
            get { return _ProfileImage; }
            set { _ProfileImage = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Name) on item 'ApplicationUnderTest.MyProfilePageUI.txtName'.", repo.ApplicationUnderTest.MyProfilePageUI.txtNameInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.ApplicationUnderTest.MyProfilePageUI.txtNameInfo, "InnerText", Name);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ProfileImage) on item 'ApplicationUnderTest.MyProfilePageUI.ProfileImage'.", repo.ApplicationUnderTest.MyProfilePageUI.ProfileImageInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.ApplicationUnderTest.MyProfilePageUI.ProfileImageInfo, "InnerText", ProfileImage);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ProfileImage) on item 'ApplicationUnderTest.MyProfilePageUI.lblUserImage'.", repo.ApplicationUnderTest.MyProfilePageUI.lblUserImageInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.MyProfilePageUI.lblUserImageInfo, "InnerText", ProfileImage);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$UserName) on item 'ApplicationUnderTest.MyProfilePageUI.lblUserName'.", repo.ApplicationUnderTest.MyProfilePageUI.lblUserNameInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.MyProfilePageUI.lblUserNameInfo, "InnerText", UserName);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
