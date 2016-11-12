﻿using System;
using Marten.Schema;

namespace Octogami.ProviderDirectory.Application.Domain
{
	public class Provider
	{
		[Identity]
		public Guid ProviderId { get; set; }

		public string NPI { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }

		public Address Address { get; set; }
	}

	public class Address
	{
		public string LineOne { get; set; }
		public string LineTwo { get; set; }
		public string City { get; set; }
		public State State { get; set; }
		public string Zip { get; set; }
	}

	public class State
	{
		public string Name { get; set; }
		public string Abbreviation { get; set; }
	}
}