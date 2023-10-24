//namespace = workspace = grupo de classes = pacote
namespace Loja139;

// Generated by Selenium IDE
//Pacotes = dependências = bibliotecas
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

[TestFixture] //Configuração do Teste
//Esta é a Classe
public class FluxoSimplesTest {
  //Atributos = Caracteristicas = Campos
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
 
 //Funções e Métodos
  [SetUp] //Inicia o Teste
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string,object>();
  }
  [TearDown] //Encerra o Teste
  protected void TearDown() {
    driver.Quit();
  }
  [Test] //Executa o Teste
  public void fluxoSimples() {
    driver.Navigate().GoToUrl("https://www.saucedemo.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1920, 1050);
    Assert.That(driver.Title, Is.EqualTo("Swag Labs"));
    driver.FindElement(By.CssSelector("*[data-test=\"username\"]")).Click();
    driver.FindElement(By.CssSelector("*[data-test=\"username\"]")).SendKeys("standard_user");
    driver.FindElement(By.CssSelector("*[data-test=\"password\"]")).Click();
    driver.FindElement(By.CssSelector("*[data-test=\"password\"]")).SendKeys("secret_sauce");
    driver.FindElement(By.CssSelector("*[data-test=\"login-button\"]")).Click();
    driver.FindElement(By.CssSelector("#item_4_title_link > .inventory_item_name")).Click();
    Assert.That(driver.FindElement(By.CssSelector(".inventory_details_name")).Text, Is.EqualTo("Sauce Labs Backpack"));
    Assert.That(driver.FindElement(By.CssSelector(".inventory_details_price")).Text, Is.EqualTo("$29.99"));
    driver.FindElement(By.CssSelector("*[data-test=\"add-to-cart-sauce-labs-backpack\"]")).Click();
    driver.FindElement(By.LinkText("1")).Click();
    Assert.That(driver.FindElement(By.CssSelector(".inventory_item_name")).Text, Is.EqualTo("Sauce Labs Backpack"));
    Assert.That(driver.FindElement(By.CssSelector(".inventory_item_price")).Text, Is.EqualTo("$29.99"));
    driver.FindElement(By.CssSelector("*[data-test=\"checkout\"]")).Click();
  }
}
