import { Injectable } from '@angular/core';
import { HttpRequest, HttpResponse, HttpHandler, HttpEvent, HttpInterceptor, HTTP_INTERCEPTORS } from '@angular/common/http';
import { Observable, of, throwError } from 'rxjs';
import { delay, mergeMap, materialize, dematerialize } from 'rxjs/operators';



@Injectable()
export class FakeBackendInterceptor implements HttpInterceptor {
    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        const { url, method, headers, body } = request;

        // wrap in delayed observable to simulate server api call
        return of(null)
            .pipe(mergeMap(handleRoute))
            .pipe(materialize()) // call materialize and dematerialize to ensure delay even if an error is thrown (https://github.com/Reactive-Extensions/RxJS/issues/648)
            .pipe(delay(500))
            .pipe(dematerialize());

        function handleRoute() {
            switch (true) {
                case (url.includes('http://localhost:15811') || url.endsWith('/users/authenticate') )
                && method === 'POST':
                    return authenticate();
                default:
                    // pass through any requests not handled above
                    return next.handle(request);
            }
        }

        // route functions

        function authenticate() {
            return ok({
                info: "author: nguyendat, phone: 0986565786",
                code: 200,
                data: "MIIEezCCA2OgAwIBAgIQVAEBCZxXydq3MzyurxBnsjANBgkqhkiG9w0BAQUFADBgMQswCQYDVQQGEwJWTjE6MDgGA1UECgwxQ8OUTkcgVFkgQ+G7lCBQSOG6pk4gVknhu4ROIFRIw5RORyBORVdURUwtVEVMRUNPTTEVMBMGA1UEAxMMTkVXVEVMLUNBIHYyMB4XDTIwMDUzMDA0Mzg1NloXDTIyMTAyNTAxMTgyN1owYDELMAkGA1UEBhMCVk4xMTAvBgNVBAMMKEPDlE5HIFRZIFROSEggQ8OUTkcgTkdI4buGIFRIIFZJ4buGVCBOQU0xHjAcBgoJkiaJk/IsZAEBDA5NU1Q6MDEwOTE4Nzk1OTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEAzGSky2nNnnQKB8WOoNiSEl1lCnGvjXKubawjOi8HtpJJ6m0O/JtHmbkOSJpot6qlQujUjK3aid5VnJzQds2ar4nZkG6Y7jEGQZRISBubv7qPyLzfXRiXlyAmCYmJFrYMwx8MkjpfhvlFbXDRmf8W+8txbR6QQ7XhhjxiPWiH8UUCAwEAAaOCAbMwggGvMAwGA1UdEwEB/wQCMAAwHwYDVR0jBBgwFoAUgvDxIe/+Tlg0cW/5jEIPPyHdVZswawYIKwYBBQUHAQEEXzBdMC4GCCsGAQUFBzAChiJodHRwOi8vcHViMi5uZXdjYS52bi9uZXd0ZWwtY2EuY3J0MCsGCCsGAQUFBzABhh9odHRwOi8vb2NzcDIubmV3Y2Eudm4vcmVzcG9uZGVyMBwGA1UdEQQVMBOBEUhvb21kQHZpZXRzZW5zLnZuMFkGA1UdIARSMFAwTgYMKwYBBAGB7QMBCQMBMD4wIwYIKwYBBQUHAgEWF2h0dHA6Ly9wdWIubmV3Y2Eudm4vcnBhMBcGCCsGAQUFBwICMAsMCU9TX05ld18zWTA0BgNVHSUELTArBggrBgEFBQcDAgYIKwYBBQUHAwQGCisGAQQBgjcKAwwGCSqGSIb3LwEBBTAzBgNVHR8ELDAqMCigJqAkhiJodHRwOi8vY3JsMi5uZXdjYS52bi9uZXd0ZWwtY2EuY3JsMB0GA1UdDgQWBBRfjWbw3YqtOOJIvPZZc4vEt9eIlzAOBgNVHQ8BAf8EBAMCBPAwDQYJKoZIhvcNAQEFBQADggEBADdEEGaHjyLhvuAE9iEGJLUcyW4qvG1CBfTlTpVwEvkB7/nwuozKoiRCfrnv2pkhQ3OaYd8VwxAOwiQgmSOyi0UV4qbReYN/JnfAxGOm3ZIhtNpcGNh8G9npau2JEoAKiyKwy0b5oQJzNNbC7VVXT6pcZblOpHWjjuEeQR+V2+z2WqDdRS+3gFf3R6jbgTqfmEMhWu+z5XYPYwDPMJCxAhLP+bbPGLErRWJ2QCWHTUcYOHDqdC+qIS5XWe22Em0DNg7lH82enJ433qk5iDoC/dxcK9/RUrnlFMI3Iy/SEz652LEhQ5bQKlMdQtQZ3TtTPUcgxGh7VWDOzp9ESerIAdY=",
                description: "Cert is success!",
                about: null,
                strSessionId: "1IXDWIRQE1TIEVM7C7CC2MGHBGIH3XWHCPG6SQM05GS5WSYC1QCTPIVPBPBP"
            })
        }


        // helper functions

        function ok(body?) {
            return of(new HttpResponse({ status: 200, body }))
        }

        function error(message) {
            return throwError({ error: { message } });
        }

        function unauthorized() {
            return throwError({ status: 401, error: { message: 'Unauthorised' } });
        }

        function isLoggedIn() {
            return headers.get('Authorization') === 'Bearer fake-jwt-token';
        }

        function idFromUrl() {
            const urlParts = url.split('/');
            return parseInt(urlParts[urlParts.length - 1]);
        }
    }
}
