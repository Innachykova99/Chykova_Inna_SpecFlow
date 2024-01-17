using InnaFeature.Helpers.Browser;
using OpenQA.Selenium;

namespace InnaFeature.Pages
{
    internal class Forms : BasePage
    {
        public Forms(IBrowserHelper browserHelper) : base(browserHelper)
        {

        }
        public IWebElement InputFields(string fieldname) =>
             browserHelper.WebDriver.FindElement(By.XPath($"//*[@id='{fieldname}']"));

        public IWebElement FemaleRadioButton =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@name='gender' and contains(@value, 'Female')]"));

        public IWebElement DateOfBirthForm =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@id='dateOfBirthInput']"));

        public IWebElement MonthSelect =>
           browserHelper.WebDriver.FindElement(By.XPath("//*[@class = 'react-datepicker__month-select']"));

        public IWebElement MonthOption(string monthNumber) =>
           browserHelper.WebDriver.FindElement(By.XPath($"//*[@class='react-datepicker__month-select']//option[contains(@value, '{monthNumber}')]\""));
        
        public IWebElement YearSelect =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@class = 'react-datepicker__year-select']"));
        
        public IWebElement YearOption(string yearNumber) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[@class = 'react-datepicker__year-select']//option[contains(@value, '{yearNumber}')]"));
        
        public IWebElement DateOption(string dateNumber) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[@id='dateOfBirth']//*[@class='react-datepicker__day react-datepicker__day--{dateNumber}']"));
        
        public IWebElement SubjectsInput =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@id='subjectsContainer']"));
        
        public IWebElement HobbiesCheckbox(string hobbyname) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[@type='checkbox']/following-sibling::label[text()='{hobbyname}']"));
        
        public IWebElement StateCityDdls(string dropdownName) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[@id='{dropdownName}']"));
        
        public IWebElement StateCityOptions(string optionName) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[contains(@class, 'css-11unzgr')]//*[contains(@class, 'css-yt9ioa-option') and contains(text(), '{optionName}')]"));
        
        public IWebElement SubmitFormButton =>
            browserHelper.WebDriver.FindElement(By.XPath("//*[@id='submit']"));
        
        public IWebElement DataInModal(string fieldName, string expectedValue) =>
            browserHelper.WebDriver.FindElement(By.XPath($"//*[@class = 'table-responsive']//td[contains(text(), '{fieldName}')]/following-sibling::td[contains(text(), '{expectedValue}')]"));

        public void InputFieldsAndSendKeys(string fieldname, string value)
        {
            IWebElement inputField = InputFields(fieldname);
            inputField.Clear();
            inputField.SendKeys(value);

        }
    }
}