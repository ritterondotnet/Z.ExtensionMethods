// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_DirectoryInfo_DeleteFilesWhere
    {
        [TestMethod]
        public void DeleteFilesWhere()
        {
            // Type
            var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "System_IO_DirectoryInfo_DeleteFilesWhere"));
            Directory.CreateDirectory(root.FullName);

            var file1 = new FileInfo(Path.Combine(root.FullName, "test.txt"));
            var file2 = new FileInfo(Path.Combine(root.FullName, "test.cs"));
            var file3 = new FileInfo(Path.Combine(root.FullName, "test.asp"));
            using (FileStream f = file1.Create())
            {
            }
            using (FileStream f = file2.Create())
            {
            }
            using (FileStream f = file3.Create())
            {
            }

            // Exemples
            root.DeleteFilesWhere(x => x.Extension == ".cs");
            FileInfo[] result = root.GetFiles();

            // Unit Test
            Assert.AreEqual(2, result.Length);
        }
    }
}