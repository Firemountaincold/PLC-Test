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
        public string function
        {
            get;
            set;
        }
        public int funcadd
        {
            get;
            set;
        }
        public int funcvalue
        {
            get;
            set;
        }
        public TestModel()
        {

        }
        public TestModel(int settime,int PLCindex,int objectindex,string function,int funcadd,int funcvalue)
        {
            this.settime = settime;
            this.PLCindex = PLCindex;
            this.objectindex = objectindex;
            this.function = function;
            this.funcadd = funcadd;
            this.funcvalue = funcvalue;
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

    public class ThreadClass
    {
        public TestModel[] tms;
        public PLCModel[] pms;
        public int epoch;
        public ThreadClass(TestModel[] tms, PLCModel[] pms, int epoch)
        {
            this.tms = tms;
            this.pms = pms;
            this.epoch = epoch;
        }
    }
}
