A couple of projects that implement thegatehousewereham.com website - it's just a few text pages and a simple shop design, although nothing much working at the minute.

The twitter, instagram and github logos are from feathericons.com - open source and hopefully free to use icon website.

**Note, to run under docker, you need to give it an SSL certificate, which you can create using dotnet dev-certs https -ep <path.pfx> and then adjusting the two kestrel related environment variables.**

**These two environment variables tell kestrel where to find the SSL certificate at start up.  You then need to either include a certificate, or create one locally and mount a volume so that the docker container can see it.**

    ENV Kestrel__Certificates__Default__Path=/app/certs/certificate.pfx
    ENV Kestrel__Certificates__Default__Password=Password


I now run inside a network like so:

    docker run -v /root/certs:/app/Resources/certs -e "Kestrel__Certificates__Default__Path=/app/Resources/certs/certificate.pfx" -e "Kestrel__Certificates__Default__Password=Password" --network thegatehousewereham -p 8000:80 -p 44300:443 -d --name bill potterboy1967/thegatehousewereham

Need to create the network - and connect any already started containers:

    docker network create thegatehousewereham
    docker network connect thegatehousewereham mysqlpottershop

Use the ubuntu image to create a bash shell - use the --network flag and you can interogate other containers using their names.
