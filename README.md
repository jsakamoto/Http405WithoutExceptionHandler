Http405WithoutExceptionHandler
==============================

What's this?
------------------------------

This library is a ASP.NET Http handler.

This Http handler respond only HTTP 405 (method not allowed) without System.Web.HttpException.

This Http handler is excahngable with System.Web.HttpMethodNotAllowedHandler.

How to install?
------------------------------

    PM> Install-Package Http405WithoutExceptionHandler

How to use?
------------------------------

Configure web.config on your ASP.NET web site.

example:

    <system.webServer>
      <handlers>
        <add name="OPTIONS" 
             path="*" 
             verb="OPTIONS" 
             type="Toolbelt.Web.Http405WithoutExceptionHandler, Http405WithoutExceptionHandler" />
      </handlers>
    </system.webServer>
