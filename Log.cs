﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WeightRecord
{
    public class Log
    {
        private string Event { get; set; }
        private DateTime Time { get; set; }


        //注册
        public void RegisterLog(string userEventname, string Time)
        {            //判断是否已经有了这个文件
            if (!System.IO.File.Exists("log.txt"))
            {
                //没有则创建这个文件
                FileStream fs1 = new FileStream("log.txt", FileMode.Create, FileAccess.Write);//创建写入文件               
                //System.IO.File.SetAttributes(@"log.txt", FileAttributes.Hidden); //设置文件属性为隐藏
                StreamWriter sw = new StreamWriter(fs1);
                sw.WriteLine(userEventname.Trim() + " " + Time.Trim());//开始写入值
                sw.Close();
                fs1.Close();
                //return "注册成功";
            }
            else
            {
                FileStream fs = new FileStream("log.txt", FileMode.Append, FileAccess.Write);
                //  System.IO.File.SetAttributes(@"log.txt", FileAttributes.Hidden);
                StreamWriter sr = new StreamWriter(fs);

                sr.WriteLine(userEventname.Trim() + " " + Time.Trim());//开始写入值
                sr.Close();
                fs.Close();
                //  return "注册成功";
            }

        }

    }
}
