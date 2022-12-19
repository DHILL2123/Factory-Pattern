﻿using System;
namespace FactoryPattern
{
	public interface ICreditCard
	{
		string GetCardType();
		int GetCreditLimit();
		int GetAnnualCharge();
	}
}

