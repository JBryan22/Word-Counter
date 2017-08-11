using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
      [TestMethod]
      public void CountRepeats_UserEntersNonMatchingWordReturnsZero_0()
      {
          RepeatCounter newCount = new RepeatCounter();
          int expected = 0;

          int actual = newCount.CountRepeats("Goodbye", "Hello");

          Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CountRepeats_UserEntersMatchingWordReturnsOne_0()
      {
          RepeatCounter newCount = new RepeatCounter();
          int expected = 1;

          int actual = newCount.CountRepeats("Hello", "Hello");

          Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CountRepeats_UserEntersSentenceWithMatchingWordReturnsOne_1()
      {
          RepeatCounter newCount = new RepeatCounter();
          int expected = 1;

          int actual = newCount.CountRepeats("Hello there", "Hello");

          Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CountRepeats_UserEntersSentenceWithMatchingWordsReturns3_3()
      {
          RepeatCounter newCount = new RepeatCounter();
          int expected = 3;

          int actual = newCount.CountRepeats("hello hello how are you doing hello", "Hello");

          Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void CountRepeats_UserEntersSentenceWithWordsContainingMatchingWordsReturns3_3()
      {
          RepeatCounter newCount = new RepeatCounter();
          int expected = 3;

          int actual = newCount.CountRepeats("I was walking my cat to the cathedral. It was a cathartic experience.", "cat");

          Assert.AreEqual(expected, actual);
      }
  }
}