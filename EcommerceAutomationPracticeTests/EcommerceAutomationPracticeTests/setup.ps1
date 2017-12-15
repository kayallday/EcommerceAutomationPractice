function Install-StandardPackages {
    param(
        [Parameter(position=0, mandatory=$true)]
        [string]$projectName
    )

    Install-Package elmah -ProjectName $projectName
    Install-Package SqlServerCompact -ProjectName $projectName
    Install-Package Newtonsoft.Json -ProjectName $projectName
    Install-Package NUnit -ProjectName $projectName
    Install-Package NUnit.Runners -ProjectName $projectName
    Install-Package NUnit.ConsoleRunner -ProjectName $projectName
    Install-Package NUnit.Console -ProjectName $projectName
    Install-Package NUnit3TestAdapter -ProjectName $projectName
    Install-Package SpecFlow.NUnit.Runners -ProjectName $projectName
    Install-Package SpecFlow.NUnit -ProjectName $projectName
    Install-Package SpecFlow -ProjectName $projectName
    Install-Package Selenium.Chrome.WebDriver -ProjectName $projectName
    Install-Package Selenium.Firefox.WebDriver -ProjectName $projectName
    Install-Package Selenium.PhantomJS.WebDriver -ProjectName $projectName
    Install-Package Selenium.Support -ProjectName $projectName
    Install-Package Selenium.WebDriver -ProjectName $projectName
    Install-Package Selenium.WebDriver.GeckoDriver.Win64 -ProjectName $projectName
    Install-Package Selenium.WebDriverBackedSelenium -ProjectName $projectName
    Install-Package Microsoft.NETCore.Platforms -ProjectName $projectName
    Install-Package NETStandard.Library -ProjectName $projectName
}

function Install-StandardPackagesForAllProjects {
    foreach ($project in Get-Project -all) {
        Install-StandardPackages $project.Name
    }
}
