﻿using System;
using System.Runtime.InteropServices;

namespace CredNet.Interop
{
	[ComConversionLoss]
	
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct tagCABOOL
	{
		public uint cElems;

		[ComConversionLoss]
		public IntPtr pElems;
	}
}
