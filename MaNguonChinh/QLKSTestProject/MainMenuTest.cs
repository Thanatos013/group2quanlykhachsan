﻿using QLKS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLKSTestProject
{
    
    
    /// <summary>
    ///This is a test class for MainMenuTest and is intended
    ///to contain all MainMenuTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MainMenuTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for StartPoint
        ///</summary>
        [TestMethod()]
        public void StartPointTest()
        {
            QLKS.MainMenu target = new QLKS.MainMenu(); // TODO: Initialize to an appropriate value
            Point expected = new Point(); // TODO: Initialize to an appropriate value
            Point actual;
            target.StartPoint = expected;
            actual = target.StartPoint;
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for PB_XoaPhong_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void PB_XoaPhong_ClickTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.PB_XoaPhong_Click(sender, e);
        }

        /// <summary>
        ///A test for PB_TraCuuPhong_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void PB_TraCuuPhong_ClickTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.PB_TraCuuPhong_Click(sender, e);
        }

        /// <summary>
        ///A test for PB_TraCuuPhieuThue_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void PB_TraCuuPhieuThue_ClickTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.PB_TraCuuPhieuThue_Click(sender, e);
        }

        /// <summary>
        ///A test for PB_ThemPhong_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void PB_ThemPhong_ClickTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.PB_ThemPhong_Click(sender, e);
        }

        /// <summary>
        ///A test for PB_SuaPhong_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void PB_SuaPhong_ClickTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.PB_SuaPhong_Click(sender, e);
        }

        /// <summary>
        ///A test for PB_MainMenu_MouseMove
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void PB_MainMenu_MouseMoveTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            MouseEventArgs e = null; // TODO: Initialize to an appropriate value
            target.PB_MainMenu_MouseMove(sender, e);
            
        }

        /// <summary>
        ///A test for PB_MainMenu_MouseDown
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void PB_MainMenu_MouseDownTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            MouseEventArgs e = null; // TODO: Initialize to an appropriate value
            target.PB_MainMenu_MouseDown(sender, e);
            
        }

        /// <summary>
        ///A test for PB_DatPhong_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void PB_DatPhong_ClickTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.PB_DatPhong_Click(sender, e);
            
        }

        /// <summary>
        ///A test for PB_BaoCaoDoanhThu_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void PB_BaoCaoDoanhThu_ClickTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.PB_BaoCaoDoanhThu_Click(sender, e);
            
        }

        /// <summary>
        ///A test for MoveForm
        ///</summary>
        [TestMethod()]
        public void MoveFormTest()
        {
            QLKS.MainMenu target = new QLKS.MainMenu(); // TODO: Initialize to an appropriate value
            Point distance = new Point(); // TODO: Initialize to an appropriate value
            target.MoveForm(distance);
            
        }

        /// <summary>
        ///A test for MainMenu_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void MainMenu_LoadTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.MainMenu_Load(sender, e);
            
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void InitializeComponentTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void DisposeTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            
        }

        /// <summary>
        ///A test for BT_ThuNho_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void BT_ThuNho_ClickTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.BT_ThuNho_Click(sender, e);
            
        }

        /// <summary>
        ///A test for BT_Thoat_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void BT_Thoat_ClickTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.BT_Thoat_Click(sender, e);
            
        }
        
        /// <summary>
        ///A test for BT_TCKH_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("QLKS.exe")]
        public void BT_TCKH_ClickTest()
        {
            MainMenu_Accessor target = new MainMenu_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.BT_TCKH_Click(sender, e);
            
        }        

        /// <summary>
        ///A test for MainMenu Constructor
        ///</summary>
        [TestMethod()]
        public void MainMenuConstructorTest()
        {
            QLKS.MainMenu target = new QLKS.MainMenu();
        }
    }
}
