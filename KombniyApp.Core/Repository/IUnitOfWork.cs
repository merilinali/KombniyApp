﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using KombniyApp.Core.Repository;

namespace KombniyApp.Core.Repository
{
	public interface IUnitOfWork : IDisposable
	{

		IUserRepository Users { get; }
		IWardrobeRepository Wardrobes { get; }
		IProductRepository Product { get; }
		IStlinAndEnvironmentRepo stlinAndEnvironmentRepo { get; }
		IStylinManageRepo stylinManageRepo { get; }



		Task<int> CommitAsync();
	}
}
