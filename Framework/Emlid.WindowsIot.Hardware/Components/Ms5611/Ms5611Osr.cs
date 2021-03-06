﻿namespace Emlid.WindowsIot.Hardware.Components.Ms5611
{
    /// <summary>
    /// <see cref="Ms5611Device"/> conversion Over-Sampling Rate (OSR).
    /// </summary>
    /// <remarks>
    /// These offsets are added to either the <see cref="Ms5611Command.ConvertD1Pressure"/> or
    /// <see cref="Ms5611Command.ConvertD2Temperature"/> commands to specify the sample rate
    /// at which to perform the calculation.
    /// </remarks>
    public enum Ms5611Osr
    {
        /// <summary>
        /// 256 times.
        /// </summary>
        Osr256 = 256,

        /// <summary>
        /// 512 times.
        /// </summary>
        Osr512 = 512,

        /// <summary>
        /// 1024 times.
        /// </summary>
        Osr1024 = 1024,

        /// <summary>
        /// 2048 times.
        /// </summary>
        Osr2048 = 2048,

        /// <summary>
        /// 4096 times.
        /// </summary>
        Osr4096 = 4096
    }
}
