﻿using System;

namespace ClientCredentialsFlowRaw
{
    public class Diary
    {
        public int Id { get; set; }
        public long UserId { get; set; }
        public DateTime DiaryDate { get; set; }
        public string Text { get; set; }
    }
}
