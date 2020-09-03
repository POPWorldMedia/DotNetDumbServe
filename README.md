# DotNetDumbServe

This project uses the shell of the aspnetcore bits to serve a static site on Linux app services. Why does anyone need this? Well, I don't know why **you** need it, but we need it because:

* Linux app services on Azure aren't based on IIS, so the serving magic is deferred to whatever platform you're using, like dotnet, Java, node, etc.
* Some of the other options we tried didn't do things like provide the cache headers, do gzip and other vitally important things.
* Believe it or not, we have instances where we still upload static stuff to sites via FTP.
* Yeah, there's a new static site product, but it's in preview. Also, we have stuff out there pointing to `https://<appservicename>.azurewebsites.net` because the cert was free.
* We already pay for app service plans that are totally not stressed and don't want to pay for more things.

## To use it
* Clone it
* Build it
* Deploy it
* Upload stuff into wwwroot to serve it
