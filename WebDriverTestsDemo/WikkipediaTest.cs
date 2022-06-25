using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

//create new cgrome browser instance
var driver = new ChromeDriver();

//navigate to Wikipedia
driver.Url = "https://wikipedia.org";

System.Console.WriteLine("CURRENT TITLE: " + driver.Title);

//locate search button(FIELD) by ID
var searchField = driver.FindElement(By.Id("searchInput"));

//click on element
searchField.Click();

//type QA and press ENTER button on keyboard
searchField.SendKeys("QA" + Keys.Enter);

System.Console.WriteLine("TITLE AFTER SEARCH: " +driver.Title);

//close browser
driver.Quit();



