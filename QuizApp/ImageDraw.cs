﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace QuizApp
{
    public class ImageDraw
    {
        //プロパティの定義
        public Bitmap Image { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        //コンストラクタ
        public ImageDraw(string imagePath,int x)
        {
            Image = new Bitmap(imagePath);
            X = x;
        }
    }
}
