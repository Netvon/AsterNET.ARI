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
	/// Notification that a bridge has been created.
	/// </summary>
	public class BridgeCreatedEvent  : Event
	{

		/// <summary>
		///
		/// </summary>
		// public EventsActions Event { get; set; }


		/// <summary>
		/// no description provided
		/// </summary>
		public Bridge Bridge { get; set; }

	}
}
