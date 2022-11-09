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
    ///The EditProfile recording.
    /// </summary>
    [TestModule("4dac9d55-d849-42c7-a068-8eb92b54b36e", ModuleType.Recording, 1)]
    public partial class EditProfile : ITestModule
    {
        /// <summary>
        /// Holds an instance of the PerromartRepository repository.
        /// </summary>
        public static PerromartRepository repo = PerromartRepository.Instance;

        static EditProfile instance = new EditProfile();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EditProfile()
        {
            FirstName = "";
            LastName = "";
            name = "InnerText";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EditProfile Instance
        {
            get { return instance; }
        }

#region Variables

        string _FirstName;

        /// <summary>
        /// Gets or sets the value of variable FirstName.
        /// </summary>
        [TestVariable("6c821914-abbe-4538-8cdd-be9de2768ff5")]
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        string _LastName;

        /// <summary>
        /// Gets or sets the value of variable LastName.
        /// </summary>
        [TestVariable("6f013f00-4f18-4597-825e-41232440b1c3")]
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        string _name;

        /// <summary>
        /// Gets or sets the value of variable name.
        /// </summary>
        [TestVariable("17c487dc-ffd4-4f01-b735-a5b80f3719da")]
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable item.
        /// </summary>
        [TestVariable("849b6594-8092-4626-a50a-743feb7f4b50")]
        public string item
        {
            get { return repo.item; }
            set { repo.item = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'ApplicationUnderTest.HomePageUI.iconDropdown' at Center.", repo.ApplicationUnderTest.HomePageUI.iconDropdownInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.HomePageUI.iconDropdown.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.HomePageUI.lblItem' at Center.", repo.ApplicationUnderTest.HomePageUI.lblItemInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.HomePageUI.lblItem.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyProfilePageUI.iconEdit' at Center.", repo.ApplicationUnderTest.MyProfilePageUI.iconEditInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.MyProfilePageUI.iconEdit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyProfilePageUI.txtFirstName' at Center.", repo.ApplicationUnderTest.MyProfilePageUI.txtFirstNameInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.MyProfilePageUI.txtFirstName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.MyProfilePageUI.txtFirstName'.", repo.ApplicationUnderTest.MyProfilePageUI.txtFirstNameInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.MyProfilePageUI.txtFirstName);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ApplicationUnderTest.MyProfilePageUI.txtFirstName'.", repo.ApplicationUnderTest.MyProfilePageUI.txtFirstNameInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.MyProfilePageUI.txtFirstName.EnsureVisible();
            Keyboard.Press("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$FirstName' with focus on 'ApplicationUnderTest.MyProfilePageUI.txtFirstName'.", repo.ApplicationUnderTest.MyProfilePageUI.txtFirstNameInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.MyProfilePageUI.txtFirstName.PressKeys(FirstName);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyProfilePageUI.txtLastName' at Center.", repo.ApplicationUnderTest.MyProfilePageUI.txtLastNameInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.MyProfilePageUI.txtLastName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'ApplicationUnderTest.MyProfilePageUI.txtLastName'.", repo.ApplicationUnderTest.MyProfilePageUI.txtLastNameInfo, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.ApplicationUnderTest.MyProfilePageUI.txtLastName);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'ApplicationUnderTest.MyProfilePageUI.txtLastName'.", repo.ApplicationUnderTest.MyProfilePageUI.txtLastNameInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.MyProfilePageUI.txtLastName.EnsureVisible();
            Keyboard.Press("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LastName' with focus on 'ApplicationUnderTest.MyProfilePageUI.txtLastName'.", repo.ApplicationUnderTest.MyProfilePageUI.txtLastNameInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.MyProfilePageUI.txtLastName.PressKeys(LastName);
            Delay.Milliseconds(20);
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$FirstName' on item 'ApplicationUnderTest.MyProfilePageUI.txtFirstName'.", repo.ApplicationUnderTest.MyProfilePageUI.txtFirstNameInfo, new RecordItemIndex(11));
            //repo.ApplicationUnderTest.MyProfilePageUI.txtFirstName.Element.SetAttributeValue("Value", FirstName);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '$LastName' on item 'ApplicationUnderTest.MyProfilePageUI.txtLastName'.", repo.ApplicationUnderTest.MyProfilePageUI.txtLastNameInfo, new RecordItemIndex(12));
            //repo.ApplicationUnderTest.MyProfilePageUI.txtLastName.Element.SetAttributeValue("Value", LastName);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyProfilePageUI.btnSave' at Center.", repo.ApplicationUnderTest.MyProfilePageUI.btnSaveInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.MyProfilePageUI.btnSave.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}