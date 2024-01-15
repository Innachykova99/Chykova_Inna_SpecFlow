using OpenQA.Selenium;

namespace InnaFeature.Pages
{
    internal class Forms : BasePage
    {
        public Forms(IWebDriver driver) : base(driver)
        {

        }
        public IWebElement InputFields(string fieldname) =>
            WebDriver.FindElement(By.XPath($"//*[@id='{fieldname}']"));
        public IWebElement FemaleRadioButton =>
            WebDriver.FindElement(By.XPath("//*[@name='gender' and contains(@value, 'Female')]"));
        public IWebElement DateOfBirthForm =>
            WebDriver.FindElement(By.XPath("//*[@id='dateOfBirthInput']"));
        public IWebElement MonthSelect =>
            WebDriver.FindElement(By.XPath("//*[@class = 'react-datepicker__month-select']"));
        public IWebElement MonthOption(string monthNumber) =>
            WebDriver.FindElement(By.XPath($"//*[@class='react-datepicker__month-select']//option[contains(@value, '{monthNumber}')]\""));
        public IWebElement YearSelect =>
            WebDriver.FindElement(By.XPath("//*[@class = 'react-datepicker__year-select']"));
        public IWebElement YearOption(string yearNumber) =>
            WebDriver.FindElement(By.XPath($"//*[@class = 'react-datepicker__year-select']//option[contains(@value, '{yearNumber}')]"));
        public IWebElement DateOption(string dateNumber) =>
            WebDriver.FindElement(By.XPath($"//*[@id='dateOfBirth']//*[@class='react-datepicker__day react-datepicker__day--{dateNumber}']"));
        public IWebElement SubjectsInput =>
            WebDriver.FindElement(By.XPath("//*[@id='subjectsContainer']"));
        public IWebElement HobbiesCheckbox(string hobbyname) =>
            WebDriver.FindElement(By.XPath($"//*[@type='checkbox']/following-sibling::label[text()='{hobbyname}']"));
        public IWebElement StateCityDdls(string dropdownName) =>
            WebDriver.FindElement(By.XPath($"//*[@id='{dropdownName}']"));
        public IWebElement StateCityOptions(string optionName) =>
            WebDriver.FindElement(By.XPath($"//*[contains(@class, 'css-11unzgr')]//*[contains(@class, 'css-yt9ioa-option') and contains(text(), '{optionName}')]"));
        public IWebElement SubmitFormButton =>
            WebDriver.FindElement(By.XPath("//*[@id='submit']"));
        public IWebElement DataInModal(string fieldName, string expectedValue) =>
            WebDriver.FindElement(By.XPath($"//*[@class = 'table-responsive']//td[contains(text(), '{fieldName}')]/following-sibling::td[contains(text(), '{expectedValue}')]"));

        public void NavigateToTheSection(string section)
        {
            IWebElement sectionButton = Section(section);
            sectionButton.Click();

        }

        public void InputFieldsAndSendKeys(string fieldname, string value)
        {
            IWebElement inputField = InputFields(fieldname);
            inputField.Clear();
            inputField.SendKeys(value);

        }


    }
}


