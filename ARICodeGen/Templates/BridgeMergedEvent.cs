﻿/*
	AsterNET ARI Framework
	Automatically generated file @ 27/05/2014 20:58:03
*/
using System;
using System.Collections.Generic;
using AsterNET.ARI.Actions;

namespace AsterNET.ARI.Models
{
	/// <summary>
	/// Notification that one bridge has merged into another.
	/// </summary>
	public class BridgeMergedEvent  : Event
	{

		/// <summary>
		///
		/// </summary>
		// public EventsActions Event { get; set; }


		/// <summary>
		/// no description provided
		/// </summary>
		public Bridge Bridge { get; set; }

		/// <summary>
		/// no description provided
		/// </summary>
		public Bridge Bridge_from { get; set; }

	}
}
