# EMR WEB

## Khởi tạo bệnh án
`http://localhost:4200/khoi-tao?IDBenhAn={IDBenhAn}`
## IDBenhAn Nội khoa
`http://localhost:4200/khoi-tao?IDBenhAn=QVJiUytXMTdlMGlBL3VTRGFZbVU0a3NUa0o5eXcxSm5peFN6VGwvYnoyZ0hiQ0NyS0R0RDZHRGdnbTJrUWluekxvQVprcitwbWlHSmxNQ01kcTRpSHR4VTdPR3JKV1NmU09SUzRObGNvNEtTaUhZM0NIbisxb0N2M0tJM2tTWkM=`

## Bệnh án bỏng
`http://localhost:4200/khoi-tao?IDBenhAn=enNVNU1xcjNacWdmS2VMVTNnaEM1cmp4dmJ1dXcrT2lqT0RlS3QzeVhkWnNwOWFlTWJabCt2OUlLK3R6T25mRVZMS3J1RVk2UXRIUEFlaVFHa0QzUis1QUYrclk2Q2x6c0t4OTl5UnZpbzFaZXRHUkpuTTA3MHljYm5sYWdyS04=`

## Bệnh án da liễu
`http://localhost:4200/khoi-tao?IDBenhAn=OVJuRmV0ZFJsWjErUnBoSkVOSk1pYTg0ZWRDU0U4akljanVabXdrV1NPdVN6OVNOR2xGRDlURmhlYWVLeFZrdkRtODQ1NTRFMlRvcTVSQ1hvbnpIRXdwbDQ0WmtwZEpkR0k2VnZxNDJGbXBHRWxlTndaVlUwTWRNUWR0REQ0OUc=`

## Bệnh án sơ sinh
`http://localhost:4200/khoi-tao?IDBenhAn=STBjcWRuM0hZYWNna3dDbC9sWEJzQm45b3VuYnJnOGFnU3pxc0Y5akxoZm9JVm9qT0U2aXlEc2NsN0E0bmtPdmpFaTcvcVFXV05tN29CNlNNYnZScXBnNUtHSzJ5S1lJWDg1TUdnaVFyWC9udFFtL3VCd3Mra21zSkR0Z1I3K00=`

## Main lib 
* [Angular CLI](https://github.com/angular/angular-cli) version 9.1.1.
* [Font Awesome Free ](https://fontawesome.com) version 5.15.3
* [Admin LTE](https://www.youtube.com/watch?v=UNomyjz0ewA) version 3.1.0

## Build & Deployment

* Build for IIS (no need web.config) debug: `ng build --base-href /`
* Build for IIS (no need web.config) prod: `ng build --base-href / --prod`
* Build for Apache (need .htaccess): `ng build`


## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

Run `ng g c something-component --flat -it -is --skipTests` or `ng g c file -is -spec false` to generate a new component with out css and test. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.
