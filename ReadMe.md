A couple of projects that implement thegatehousewereham.com website - it's just a few text pages and a simple shop design, although nothing much working at the minute.

The twitter, instagram and github logos are from feathericons.com - open source and hopefully free to use icon website.

**Note, to run under docker, you need to give it an SSL certificate, which you can create using dotnet dev-certs https -ep <path.pfx> and then adjusting the two kestrel related environment variables.**

**These two environment variables tell kestrel where to find the SSL certificate at start up.  You then need to either include a certificate, or create one locally and mount a volume so that the docker container can see it.**

    ENV Kestrel__Certificates__Default__Path=/app/certs/certificate.pfx
    ENV Kestrel__Certificates__Default__Password=Password
