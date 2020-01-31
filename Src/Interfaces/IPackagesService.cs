﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Mtch.VstsClient.Domain.Objects;

namespace Mtch.VstsClient.Interfaces
{
   /// <summary>
   ///    This interface represents service to work with VSTS Nuget packages
   /// </summary>
   public interface IPackagesService
   {
      /// <summary>
      ///    List all feeds under given project
      /// </summary>
      /// <returns></returns>
      Task<PackageVersionDetails> GetPackageVersionDetails(string feedName, string packageId, string packageVersion);

      /// <summary>
      ///    List all feeds under given project
      /// </summary>
      /// <returns></returns>
      Task<IEnumerable<Package>> GetAllPackages(string feedName);
   }
}