using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecflowBasicDemo
{
    [Binding]
    public class CalculatorFeatureStepDefinitions
    {
        CalculatorApplication cal = new CalculatorApplication();
        int i, j;
        double output;
        [Given(@"I have provided (.*) and (.*) as the inputs")]
        public void GivenIHaveProvidedAndAsTheInputs(int p0, int p1)
        {
            i = p0;
            j=p1;

            //throw new PendingStepException();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            output = cal.Add(i, j);
          //  throw new PendingStepException();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.AreEqual(p0, output); 
           // throw new PendingStepException();
        }

        [When(@"I press substract")]
        public void WhenIPressSubstract()
        {
            output = cal.Subtract(i,j);
           // throw new PendingStepException();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            output = cal.Multiply(i, j);
            //throw new PendingStepException();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            output = cal.Divide(i, j);
            // throw new PendingStepException();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(Decimal p0)
        {
            Assert.AreEqual(p0, output);
            //  throw new PendingStepException();
        }

        [Given(@"I have provided (.*) as input")]
        public void GivenIHaveProvidedAsInput(int p0)
        {
            i=p0;
           // Assert.AreEqual(p0, output);
            // throw new PendingStepException();
        }

        [When(@"I press squareroot")]
        public void WhenIPressSquareroot()
        {
            output = cal.Sqrt(i);
           // throw new PendingStepException();
        }
    }
}
