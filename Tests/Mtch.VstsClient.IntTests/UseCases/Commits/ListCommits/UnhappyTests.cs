﻿using Mtch.VstsClient.Domain.Exceptions;
using Mtch.VstsClient.Interfaces;
using Mtch.VstsClient.IntTests.TestExtensions;
using NUnit.Framework;

namespace Mtch.VstsClient.IntTests.UseCases.Commits.ListCommits
{
   [Explicit]
   public class UnhappyTests : IntegrationTestBase<ICommitsService>
   {
      private string _projectName;
      private string _repositoryId;

      [SetUp]
      public void SetUp()
      {
         _projectName = this.GetGoodProjectName();
         _repositoryId = this.GetGoodRepository(_projectName).Id;
      }

      [Test]
      public void Bad_Project_Name()
      {
         //arrange
         _projectName = "abcd";

         //act+assert
         var exception = Assert.ThrowsAsync<ProjectNotFoundException>(() => SUT().GetAllCommits(_projectName, _repositoryId));

         //print 
         exception.Print();
      }

      [Test]
      public void Bad_Repository_Id()
      {
         //arrange
         _repositoryId = "abcd";

         //act+assert
         var exception = Assert.ThrowsAsync<RepositoryNotFoundException>(() => SUT().GetAllCommits(_projectName, _repositoryId));

         //print 
         exception.Print();
      }
   }
}