using TechTalk.SpecFlow;

namespace BDDBasketDemo
{
    [Binding]
    public class StepDefinitions
    {
        [When(@"I create a new basket")]
        public void WhenICreateANewBasket()
        {
            var basket = new Basket();
        }

        [Then(@"the basket has no content")]
        public void ThenTheBasketHasNoContent()
        {
            ScenarioContext.Current.Pending();
        }
    }

    //Comment for newbranch

    public class Basket
        {
        }
    }