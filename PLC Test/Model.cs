using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Test
{
    public class TestModel
    {
        //测试流程类
        static public int testi;
        public int settime
        {
            get;
            set;
        }
        public int PLCindex
        {
            get;
            set;
        }
        public int objectindex
        {
            get;
            set;
        }
        public string memtype
        {
            get;
            set;
        }
        public int memadd
        {
            get;
            set;
        }
        public string valuetype
        {
            get;
            set;
        }
        public byte[] value
        {
            get;
            set;
        }
        public string testtype
        {
            get;
            set;
        }
        public TestModel()
        {

        }
        public TestModel(int settime, int PLCindex, int objectindex, string memtype, int memadd, string valuetype, byte[] value, string testtype)
        {
            this.settime = settime;
            this.PLCindex = PLCindex;
            this.objectindex = objectindex;
            this.memtype = memtype;
            this.memadd = memadd;
            this.valuetype = valuetype;
            this.value = value;
            this.testtype = testtype;
        }
    }

    public class PLCModel
    {
        //PLC类
        static public int plci;
        public int PLCid
        {
            get;
            set;
        }
        public string PLCname
        {
            get;
            set;
        }
        public string PLCip
        {
            get;
            set;
        }
        public string PLCport
        {
            get;
            set;
        }
        public PLCModel()
        {

        }
        public PLCModel(int PLCid,string PLCname,string PLCip,string PLcport)
        {
            this.PLCid = PLCid;
            this.PLCname = PLCname;
            this.PLCip = PLCip;
            this.PLCport = PLCport;
        }
    }

    public class ObjectModel
    {
        static public int obji;
        public int objectid
        {
            get;
            set;
        }
        public string objectip
        {
            get;
            set;
        }
        public string objectport
        {
            get;
            set;
        }
        public string objecttype
        {
            get;
            set;
        }
        public ObjectModel()
        {

        }
        public ObjectModel(int objectid,string objectip,string objectport,string objecttype)
        {
            this.objectid = objectid;
            this.objectip = objectip;
            this.objectport = objectport;
            this.objecttype = objecttype;
        }
    }
    public class ThreadClass
    {
        public TestModel[] tms;
        public PLCModel[] pms;
        public ObjectModel[] oms;
        public int epoch;
        public ThreadClass(TestModel[] tms, PLCModel[] pms, ObjectModel[] oms, int epoch)
        {
            this.tms = tms;
            this.pms = pms;
            this.oms = oms;
            this.epoch = epoch;
        }
    }
}
