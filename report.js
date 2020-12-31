$(document).ready(function() {var formatter = new CucumberHTML.DOMFormatter($('.cucumber-report'));formatter.uri("file:src/test/resources/features/SQUAD%20INFRA%20-%20Testes/Testes%20Sinteticos/Cyber%20View/Login.feature");
formatter.feature({
  "name": "Login",
  "description": "",
  "keyword": "Funcionalidade",
  "tags": [
    {
      "name": "@login"
    }
  ]
});
formatter.scenarioOutline({
  "name": "\u003cCT\u003e \u003cDescricaoCenario\u003e",
  "description": "",
  "keyword": "Esquema do Cenario"
});
formatter.step({
  "name": "que exista uma conta",
  "keyword": "Dado "
});
formatter.step({
  "name": "e realizado o login",
  "keyword": "Quando "
});
formatter.step({
  "name": "sera validado login com sucesso",
  "keyword": "Entao "
});
formatter.step({
  "name": "e realizado o logout",
  "keyword": "Quando "
});
formatter.step({
  "name": "e validado que saiu do sistema",
  "keyword": "Entao "
});
formatter.examples({
  "name": "",
  "description": "",
  "keyword": "Exemplos",
  "rows": [
    {
      "cells": [
        "CT",
        "DescricaoCenario"
      ]
    },
    {
      "cells": [
        "54876_54883_54885 - CT01",
        "LOGIN E LOGOUT COM SUCESSO CYBERVIEW 1"
      ]
    }
  ],
  "tags": [
    {
      "name": "@login-2"
    }
  ]
});
formatter.scenario({
  "name": "54876_54883_54885 - CT01 LOGIN E LOGOUT COM SUCESSO CYBERVIEW 1",
  "description": "",
  "keyword": "Esquema do Cenario",
  "tags": [
    {
      "name": "@login"
    },
    {
      "name": "@login-2"
    }
  ]
});
formatter.write("--------------------------------------------------------------------------------------------------------------------------------------------\n\u003e\u003e\u003e SETUP\n--------------------------------------------------------------------------------------------------------------------------------------------\nURL : http://10.202.10.126:8080/CoreBackoffice/login\nABA : Veloe\nPage Load : OK\nBrowser Name : FIREFOX\nBrowser Version : 84.0\nWebDriver Version : v0.27.0\n--------------------------------------------------------------------------------------------------------------------------------------------\n\u003c\u003c\u003c [OK]\n--------------------------------------------------------------------------------------------------------------------------------------------\n");
formatter.embedding("image/png", "embedded0.png", null);
formatter.before({
  "status": "passed"
});
formatter.before({
  "status": "passed"
});
formatter.step({
  "name": "que exista uma conta",
  "keyword": "Dado "
});
formatter.match({
  "location": "LoginSteps.queExistaUmaConta()"
});
formatter.result({
  "status": "passed"
});
formatter.write("--------------------------------------------------------------------------------------------------------------------------------------------\n\u003e\u003e\u003e Dado que exista uma conta [LoginSteps.queExistaUmaConta()]\n--------------------------------------------------------------------------------------------------------------------------------------------\nVEL.TESTCYBER\nJkdlgj@10301P\n--------------------------------------------------------------------------------------------------------------------------------------------\n\u003c\u003c\u003c [PASSED] [Tempo decorrido 0s] Dado que exista uma conta [LoginSteps.queExistaUmaConta()]\n--------------------------------------------------------------------------------------------------------------------------------------------\n");
formatter.step({
  "name": "e realizado o login",
  "keyword": "Quando "
});
formatter.match({
  "location": "LoginSteps.eRealizadoOLogin()"
});
formatter.result({
  "status": "passed"
});
formatter.write("--------------------------------------------------------------------------------------------------------------------------------------------\n\u003e\u003e\u003e Quando e realizado o login [LoginSteps.eRealizadoOLogin()]\n--------------------------------------------------------------------------------------------------------------------------------------------\n-------------------------------------------------------------------------------------------------------------------------------------\n---\u003e [Login.preencheLogin()]\n-------------------------------------------------------------------------------------------------------------------------------------\n----------------------------------------------------------------------------------------------------------\n---\u003e [Login.waitPageLoad()]\n----------------------------------------------------------------------------------------------------------\nEncontrado     | WaitExistAndMark         |         -                       | FindBy xpath: //table[contains(@class,\u0027login\u0027) and contains(.,\u0027ENTRAR\u0027)]    | Device FirefoxDriver: firefox on WINDOWS        | URL: http://10.202.10.126:8080/CoreBackoffice/login\n----------------------------------------------------------------------------------------------------------\n[ OK ] [Login.waitPageLoad()] 0s \u003c---\n----------------------------------------------------------------------------------------------------------\nEncontrado     | WaitExistSet             | VEL.TESTCYBER                   | FindBy xpath: //input[@id\u003d\u0027user_id\u0027]                                        | Device FirefoxDriver: firefox on WINDOWS        | URL: http://10.202.10.126:8080/CoreBackoffice/login\nEncontrado     | WaitExistSet             | Jkdlgj@10301P                   | FindBy xpath: //input[@id\u003d\u0027pass_id\u0027]                                        | Device FirefoxDriver: firefox on WINDOWS        | URL: http://10.202.10.126:8080/CoreBackoffice/login\nEncontrado     | WaitExistSelect          | portugues                       | FindBy xpath: //select[@id\u003d\u0027languageChooseId\u0027]                              | Device FirefoxDriver: firefox on WINDOWS        | URL: http://10.202.10.126:8080/CoreBackoffice/login\nEncontrado     | WaitExistClick           |         -                       | FindBy xpath: //td[@class\u003d\u0027loginbutton\u0027]/input                              | Device FirefoxDriver: firefox on WINDOWS        | URL: http://10.202.10.126:8080/CoreBackoffice/login\n-------------------------------------------------------------------------------------------------------------------------------------\n[ OK ] [Login.preencheLogin()] 4s \u003c---\n-------------------------------------------------------------------------------------------------------------------------------------\n--------------------------------------------------------------------------------------------------------------------------------------------\n\u003c\u003c\u003c [PASSED] [Tempo decorrido 4s] Quando e realizado o login [LoginSteps.eRealizadoOLogin()]\n--------------------------------------------------------------------------------------------------------------------------------------------\n");
formatter.embedding("image/png", "embedded1.png", null);
formatter.embedding("image/png", "embedded2.png", null);
formatter.step({
  "name": "sera validado login com sucesso",
  "keyword": "Entao "
});
formatter.match({
  "location": "LoginSteps.seraValidadoLoginComSucesso()"
});
formatter.result({
  "status": "passed"
});
formatter.write("--------------------------------------------------------------------------------------------------------------------------------------------\n\u003e\u003e\u003e Entao sera validado login com sucesso [LoginSteps.seraValidadoLoginComSucesso()]\n--------------------------------------------------------------------------------------------------------------------------------------------\n-------------------------------------------------------------------------------------------------------------------------------------\n---\u003e [Login.validaLogin()]\n-------------------------------------------------------------------------------------------------------------------------------------\nEncontrado     | WaitExistAndMark         |         -                       | FindBy xpath: //div[@id\u003d\u0027sesionBox\u0027]/a/span[contains(.,\u0027VELTESTCYBER\u0027)]     | Device FirefoxDriver: firefox on WINDOWS        | URL: http://10.202.10.126:8080/CoreBackoffice/login\n-------------------------------------------------------------------------------------------------------------------------------------\n[ OK ] [Login.validaLogin()] 0s \u003c---\n-------------------------------------------------------------------------------------------------------------------------------------\n--------------------------------------------------------------------------------------------------------------------------------------------\n\u003c\u003c\u003c [PASSED] [Tempo decorrido 0s] Entao sera validado login com sucesso [LoginSteps.seraValidadoLoginComSucesso()]\n--------------------------------------------------------------------------------------------------------------------------------------------\n");
formatter.embedding("image/png", "embedded3.png", null);
formatter.step({
  "name": "e realizado o logout",
  "keyword": "Quando "
});
formatter.match({
  "location": "LoginSteps.eRealizadoOLogout()"
});
formatter.result({
  "status": "passed"
});
formatter.write("--------------------------------------------------------------------------------------------------------------------------------------------\n\u003e\u003e\u003e Quando e realizado o logout [LoginSteps.eRealizadoOLogout()]\n--------------------------------------------------------------------------------------------------------------------------------------------\n-------------------------------------------------------------------------------------------------------------------------------------\n---\u003e [AreaLogada.realizaLogout()]\n-------------------------------------------------------------------------------------------------------------------------------------\nEncontrado     | WaitExistMoveToElement   |         -                       | FindBy xpath: //div[@class\u003d\u0027header_container-login\u0027]                        | Device FirefoxDriver: firefox on WINDOWS        | URL: http://10.202.10.126:8080/CoreBackoffice/login\nEncontrado     | WaitExistMoveToElement   |         -                       | FindBy xpath: //div[@id\u003d\u0027sesionBox\u0027]                                        | Device FirefoxDriver: firefox on WINDOWS        | URL: http://10.202.10.126:8080/CoreBackoffice/login\nEncontrado     | WaitExistClick           |         -                       | FindBy xpath: //div[@id\u003d\u0027sesionBox\u0027]/descendant::a[contains(.,\u0027Encerrar\u0027)]  | Device FirefoxDriver: firefox on WINDOWS        | URL: http://10.202.10.126:8080/CoreBackoffice/login\n-------------------------------------------------------------------------------------------------------------------------------------\n[ OK ] [AreaLogada.realizaLogout()] 3s \u003c---\n-------------------------------------------------------------------------------------------------------------------------------------\n--------------------------------------------------------------------------------------------------------------------------------------------\n\u003c\u003c\u003c [PASSED] [Tempo decorrido 3s] Quando e realizado o logout [LoginSteps.eRealizadoOLogout()]\n--------------------------------------------------------------------------------------------------------------------------------------------\n");
formatter.embedding("image/png", "embedded4.png", null);
formatter.embedding("image/png", "embedded5.png", null);
formatter.step({
  "name": "e validado que saiu do sistema",
  "keyword": "Entao "
});
formatter.match({
  "location": "LoginSteps.eValidadoQueSaiuDoSistema()"
});
formatter.result({
  "status": "passed"
});
formatter.write("--------------------------------------------------------------------------------------------------------------------------------------------\n\u003e\u003e\u003e Entao e validado que saiu do sistema [LoginSteps.eValidadoQueSaiuDoSistema()]\n--------------------------------------------------------------------------------------------------------------------------------------------\n-------------------------------------------------------------------------------------------------------------------------------------\n---\u003e [Login.waitPageLoad()]\n-------------------------------------------------------------------------------------------------------------------------------------\nEncontrado     | WaitExistAndMark         |         -                       | FindBy xpath: //table[contains(@class,\u0027login\u0027) and contains(.,\u0027ENTRAR\u0027)]    | Device FirefoxDriver: firefox on WINDOWS        | URL: http://10.202.10.126:8080/CoreBackoffice/login\n-------------------------------------------------------------------------------------------------------------------------------------\n[ OK ] [Login.waitPageLoad()] 0s \u003c---\n-------------------------------------------------------------------------------------------------------------------------------------\n--------------------------------------------------------------------------------------------------------------------------------------------\n\u003c\u003c\u003c [PASSED] [Tempo decorrido 0s] Entao e validado que saiu do sistema [LoginSteps.eValidadoQueSaiuDoSistema()]\n--------------------------------------------------------------------------------------------------------------------------------------------\n");
formatter.embedding("image/png", "embedded6.png", null);
formatter.after({
  "status": "passed"
});
});