using ApplicationToActivityMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ApplicationToActivityMapperTests
{
    [TestClass]
    public class ActivityMapperTest
    {

        private static IEnumerable<object[]> Data
        {
            // ReSharper disable once UnusedMember.Local
            get
            {
                yield return new object[] { ActivityCategory.Unknown, "", "" };
                yield return new object[] { ActivityCategory.Unknown, null, null };
                yield return new object[] { ActivityCategory.Unknown, null, "___" };
                yield return new object[] { ActivityCategory.Unknown, "___", null };
                yield return new object[] { ActivityCategory.Unknown, "___", "___" };

                yield return new object[] { ActivityCategory.Idle, "idle", null };
                yield return new object[] { ActivityCategory.Idle, "idle", "Not Idle" };

                yield return new object[] { ActivityCategory.Planning, "someting", "Task View" };
                yield return new object[] { ActivityCategory.Planning, "trello", "Trello" };

                yield return new object[] { ActivityCategory.Other, "taskmgr", "Task Manager" };

                yield return new object[] { ActivityCategory.Email, "mail", "mail" };

                yield return new object[] { ActivityCategory.DevCode, "vim", ".ts" };
                yield return new object[] { ActivityCategory.DevCode, "vim", "___" };
                yield return new object[] { ActivityCategory.DevCode, "rstudio", "" };
                yield return new object[] { ActivityCategory.DevCode, "firefox", ".ts" };

                yield return new object[] { ActivityCategory.DevDebug, "debug", "debug" };

                yield return new object[] { ActivityCategory.DevReview, "gerrit", "code review" };

                yield return new object[] { ActivityCategory.DevVc, "diff", "diff" };

                yield return new object[] { ActivityCategory.ReadWriteDocument, "vim", "" };
                yield return new object[] { ActivityCategory.ReadWriteDocument, "vim", "new file" };
                yield return new object[] { ActivityCategory.ReadWriteDocument, "vim", "vim" };
                //yield return new object[] { ActivityCategory.ReadWriteDocument, "snagiteditor", "" }; // Broken due to "git"
                yield return new object[] { ActivityCategory.ReadWriteDocument, "confluence", "" };

                yield return new object[] { ActivityCategory.InstantMessaging, "messenger", "messenger" };
                yield return new object[] { ActivityCategory.InstantMessaging, "firefox", "messenger" };

                yield return new object[] { ActivityCategory.WorkRelatedBrowsing, "firefox", "linkedin" };
                yield return new object[] { ActivityCategory.WorkRelatedBrowsing, "firefox", "" };

                yield return new object[] { ActivityCategory.WorkUnrelatedBrowsing, "firefox", "facebook" };

                yield return new object[] { ActivityCategory.FileNavigationInExplorer, "explorer", "" };

                yield return new object[] { ActivityCategory.OtherRdp, "vmware", "" };

                yield return new object[] { ActivityCategory.Gaming, "battle.net", "" };

                yield return new object[] { ActivityCategory.Other, "searchui", "" };
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(Data))]
        public void TestMap(ActivityCategory category, string processName, string windowTitle)
        {
            Assert.AreEqual(category, new ActivityMapper().Map(processName, windowTitle));
        }
    }
}
