﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SdsRestApiCore
{
    public class WaveData
    {
        [Key]
        public int Order { get; set; }

        public double Tau { get; set; }

        public double Radians { get; set; }

        public double Sin { get; set; }

        public double Cos { get; set; }

        public double Tan { get; set; }

        public double Sinh { get; set; }

        public double Cosh { get; set; }

        public double Tanh { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append($"Order: {Order}");
            builder.Append($", Radians: {Radians}");
            builder.Append($", Tau: {Tau}");
            builder.Append($", Sin: {Sin}");
            builder.Append($", Cos: {Cos}");
            builder.Append($", Tan: {Tan}");
            builder.Append($", Sinh: {Sinh}");
            builder.Append($", Cosh: {Cosh}");
            builder.Append($", Tanh: {Tanh}");
            return builder.ToString();
        }
    }

    public class WaveDataTarget
    {
        [Key]
        public int OrderTarget { get; set; }

        public double TauTarget { get; set; }

        public double RadiansTarget { get; set; }

        public double SinTarget { get; set; }

        public double CosTarget { get; set; }

        public double TanTarget { get; set; }

        public double SinhTarget { get; set; }

        public double CoshTarget { get; set; }

        public double TanhTarget { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append($"OrderTarget: {OrderTarget}");
            builder.Append($", RadiansTarget: {RadiansTarget}");
            builder.Append($", TauTarget: {TauTarget}");
            builder.Append($", SinTarget: {SinTarget}");
            builder.Append($", CosTarget: {CosTarget}");
            builder.Append($", TanTarget: {TanTarget}");
            builder.Append($", SinhTarget: {SinhTarget}");
            builder.Append($", CoshTarget: {CoshTarget}");
            builder.Append($", TanhTarget: {TanhTarget}");
            return builder.ToString();
        }
    }

    public class WaveDataInteger
    {
        [Key]
        public int OrderTarget { get; set; }

        public int SinInt { get; set; }

        public int CosInt { get; set; }

        public int TanInt { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append($"OrderTarget: {OrderTarget}");
            builder.Append($", SinInt: {SinInt}");
            builder.Append($", CosInt: {CosInt}");
            builder.Append($", TanInt: {TanInt}");
            return builder.ToString();
        }
    }
}
