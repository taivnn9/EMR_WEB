import { CommonModule } from "@angular/common";
import { APP_INITIALIZER, NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { BrowserModule } from "@angular/platform-browser";
import { RouterModule } from "@angular/router";
import { EmrRoutes } from "./emr.routing";


@NgModule({
    imports: [
        RouterModule.forChild(EmrRoutes),
        FormsModule,    //added here too
        ReactiveFormsModule //added here too
    ],
    declarations: [],
    entryComponents: [],  
    // providers: [
    //     SingletonService,
    //     {
    //       provide: APP_INITIALIZER,
    //       useFactory: (service: SingletonService) => function() { return service.update(); },
    //       deps: [SingletonService],
    //       multi: true
    //     }
    // ]
})

export class EmrModule { }