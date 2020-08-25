import { Component } from '@angular/core'; 
import { MyPageService } from './service/my-page.service'; 

@Component({
    selector: 'my-template',
    templateUrl: './app.component.html',     
    styles: []
})
export class AppComponent {

    TemplateHtml: any;

    constructor(private apiService: MyPageService) { }

    ngOnInit(): void {
        this.retrieveTutorials();
    }

    retrieveTutorials(): void {
        this.apiService.getAll()
            .subscribe(
                data => {
                    this.TemplateHtml = data;
                },
                error => {
                });
    } 
}
