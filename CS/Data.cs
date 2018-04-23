using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EditableDetails {
    public class DataHelper {
        public static List<Parent> CreateMasterData(int masterRowCount) {
            List<Parent> parentList = new List<Parent>();

            for (int i = 0; i < masterRowCount; i++) {
                parentList.Add(new Parent() {
                    ID = i,
                    Name = "Parent" + i.ToString()
                });
            }

            return parentList;
        }

        public static List<Child> CreateChildData(int childRowCount, int maxMasterIndex) {
            List<Child> childList = new List<Child>();
            Random r = new Random();

            for (int i = 0; i < childRowCount; i++) {
                childList.Add(new Child() {
                    ID = i,
                    Name = "Child" + i.ToString(),
                    ParentID = r.Next(maxMasterIndex)
                });
            }

            return childList;
        }
    }

    public class Parent {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Child {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ParentID { get; set; }
    }

}