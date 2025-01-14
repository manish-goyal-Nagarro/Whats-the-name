// Generated by Selenium IDE
import org.junit.Test;
import org.junit.Before;
import org.junit.After;
import static org.junit.Assert.*;
import static org.hamcrest.CoreMatchers.is;
import static org.hamcrest.core.IsNot.not;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.firefox.FirefoxDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.Dimension;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.interactions.Actions;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;
import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.Alert;
import org.openqa.selenium.Keys;
import java.util.*;
public class AddnewMovieTest {
  private WebDriver driver;
  private Map<String, Object> vars;
  JavascriptExecutor js;
  @Before
  public void setUp() {
    driver = new ChromeDriver();
    js = (JavascriptExecutor) driver;
    vars = new HashMap<String, Object>();
  }
  @After
  public void tearDown() {
    driver.quit();
  }
  @Test
  public void addMovieTest() {
    driver.get("http://autothon-nagarro-frontend-x05.azurewebsites.net/");
    driver.manage().window().setSize(new Dimension(1050, 660));
    driver.findElement(By.linkText("Login")).click();
    driver.findElement(By.name("password")).click();
    driver.findElement(By.name("password")).sendKeys("admin");
    driver.findElement(By.name("username")).sendKeys("password");
    driver.findElement(By.name("username")).sendKeys(Keys.ENTER);
    driver.findElement(By.linkText("add movie")).click();
    driver.findElement(By.cssSelector(".btn:nth-child(1)")).click();
  }
  @Test
  public void cannotAddMovie() {
    driver.get("http://autothon-nagarro-frontend-x05.azurewebsites.net/");
    driver.manage().window().setSize(new Dimension(1050, 660));
    driver.findElement(By.linkText("Login")).click();
    driver.findElement(By.name("password")).click();
    driver.findElement(By.name("password")).sendKeys("admin");
    driver.findElement(By.name("username")).sendKeys("password");
    driver.findElement(By.name("username")).sendKeys(Keys.ENTER);
    driver.findElement(By.linkText("add movie")).click();
    driver.findElement(By.name("title")).click();
    driver.findElement(By.name("title")).sendKeys("Some Cool Movie");
    driver.findElement(By.name("director")).click();
    driver.findElement(By.name("director")).sendKeys("Johnny");
    driver.findElement(By.cssSelector(".display-3 > img")).sendKeys("This is great movie to watch");
    {
      WebElement dropdown = driver.findElement(By.name("categories"));
      dropdown.findElement(By.xpath("//option[. = 'Drama']")).click();
    }
    driver.findElement(By.name("file")).click();
    driver.findElement(By.name("file")).sendKeys("http://www.comewatchmovie.com");
    driver.findElement(By.cssSelector(".btn:nth-child(1)")).click();
    driver.findElement(By.cssSelector(".btn:nth-child(1)")).click();
    driver.findElement(By.linkText("Movies")).click();
    driver.findElement(By.id("navLink")).click();
    {
      WebElement element = driver.findElement(By.id("navLink"));
      Action builder = new Actions(driver);
      builder.moveToElement(element).perform();
    }
    {
      WebElement element = driver.findElement(By.tagName("body"));
      Action builder = new Actions(driver);
      builder.moveToElement(element, 0, 0).perform();
    }
    driver.findElement(By.name("search")).click();
    driver.findElement(By.linkText("Logout")).click();
  }
  @Test
  public void validatingAddMovieFields() {
    driver.get("http://autothon-nagarro-frontend-x05.azurewebsites.net/");
    driver.manage().window().setSize(new Dimension(1050, 660));
    driver.findElement(By.linkText("Login")).click();
    driver.findElement(By.name("password")).click();
    driver.findElement(By.name("password")).sendKeys("admin");
    driver.findElement(By.name("username")).sendKeys("password");
    driver.findElement(By.name("username")).sendKeys(Keys.ENTER);
    driver.findElement(By.linkText("add movie")).click();
    driver.findElement(By.name("title")).click();
    driver.findElement(By.name("title")).sendKeys("My Moviesadfnsadjfnsjaknfkjnsakfdjnksajfknjskjnkdkjsadfbsadbfjhabsfdjbhsajfbjsabdjfbhsajdfhbjashbdjfsabdjfbhsajdfbjadsfjbhsafdjbsajdfjsabdjfbhsajdfbjsahdfjsabdjfbhsajdfbjsahbfjsabdfjbsadjfbksajfdnkansdfkjadskjfbsakjdfbkasbhdjfsabfdjbhsajdfbsajdfbjhsabjfbhdasjfbhsajdfbjsahfjhsabfjbadfbasjdfjsabhfjbsafdewrnm dsamf  na n asdfsakjdfbkjadsbkfjadsfkjdabshfb");
    driver.findElement(By.name("title")).click();
    driver.findElement(By.name("title")).sendKeys("*#$(%@#$@#$*@#$VV@#}@REW<{{WF}WF<WFP FPWER_@#$I_K{WEF}WEF>C?W:}:LFK}}~\`My Moviesadfnsadjfnsjaknf#$%#$%#%*#$%(($#$*%(($%*$%(#$kjnsakfdjnksajfknjskjnkdkjsadfbsadbfjhabsfdjbhsajfbjsabdjfbhsajdfhbjashbdjfsabdjfbhsajdfbjadsfjbhsafdjbsajdfjsabdjfbhsajdfbjsahdfjsabdjfbhsajdfbjsahbfjsabdfjbsadjfbksajfdnkansdfkjadskjfbsakjdfbkasbhdjfsabfdjbhsajdfbsajdfbjhsabjfbhdasjfbhsajdfbjsahfjhsabfjbadfbasjdfjsabhfjbsafdewrnm dsamf  na n asdfsakjdfbkjadsbkfjadsfkjdabshfb");
    driver.findElement(By.name("director")).click();
    driver.findElement(By.name("title")).click();
    driver.findElement(By.name("director")).click();
    driver.findElement(By.name("director")).sendKeys("*#$(%@#$@#$*@#$VV@#}@REW<{{WF}WF<WFP FPWER_@#$I_K{WEF}WEF>C?W:}:LFK}}~\`My Moviesadfnsadjfnsjaknf#$%#$%#%*#$%(($#$*%(($%*$%(#$kjnsakfdjnksajfknjskjnkdkjsadfbsadbfjhabsfdjbhsajfbjsabdjfbhsajdfhbjashbdjfsabdjfbhsajdfbjadsfjbhsafdjbsajdfjsabdjfbhsajdfbjsahdfjsabdjfbhsajdfbjsahbfjsabdfjbsadjfbksajfdnkansdfkjadskjfbsakjdfbkasbhdjfsabfdjbhsajdfbsajdfbjhsabjfbhdasjfbhsajdfbjsahfjhsabfjbadfbasjdfjsabhfjbsafdewrnm dsamf  na n asdfsakjdfbkjadsbkfjadsfkjdabshfb");
    driver.findElement(By.cssSelector(".row:nth-child(3) .form-control")).click();
    driver.findElement(By.cssSelector(".row:nth-child(3) .is-valid")).sendKeys("*#$(%@#$@#$*@#$VV@#}@REW<{{WF}WF<WFP FPWER_@#$I_K{WEF}WEF>C?W:}:LFK}}~\`My Moviesadfnsadjfnsjaknf#$%#$%#%*#$%(($#$*%(($%*$%(#$kjnsakfdjnksajfknjskjnkdkjsadfbsadbfjhabsfdjbhsajfbjsabdjfbhsajdfhbjashbdjfsabdjfbhsajdfbjadsfjbhsafdjbsajdfjsabdjfbhsajdfbjsahdfjsabdjfbhsajdfbjsahbfjsabdfjbsadjfbksajfdnkansdfkjadskjfbsakjdfbkasbhdjfsabfdjbhsajdfbsajdfbjhsabjfbhdasjfbhsajdfbjsahfjhsabfjbadfbasjdfjsabhfjbsafdewrnm dsamf  na n asdfsakjdfbkjadsbkfjadsfkjdabshfb");
    {
      WebElement dropdown = driver.findElement(By.name("categories"));
      dropdown.findElement(By.xpath("//option[. = 'Comedy']")).click();
    }
    {
      WebElement dropdown = driver.findElement(By.name("categories"));
      dropdown.findElement(By.xpath("//option[. = 'Drama']")).click();
    }
    {
      WebElement dropdown = driver.findElement(By.name("categories"));
      dropdown.findElement(By.xpath("//option[. = 'Drama']")).click();
    }
    driver.findElement(By.cssSelector("option:nth-child(1)")).click();
    driver.findElement(By.name("file")).click();
    driver.findElement(By.name("file")).click();
    driver.findElement(By.name("file")).sendKeys("http://www.someurl");
    driver.findElement(By.cssSelector(".btn:nth-child(1)")).click();
    driver.findElement(By.cssSelector(".btn:nth-child(1)")).click();
    driver.findElement(By.cssSelector(".btn:nth-child(1)")).click();
    driver.findElement(By.cssSelector(".btn:nth-child(1)")).click();
  }
}
