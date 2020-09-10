import { Component } from '@angular/core';
import { MyPageService } from './core/services/my-page.service'; 

@Component({
    selector: 'my-template',
  templateUrl: './app.component.html',
    styles: []
})
export class AppComponent {
    TemplateHtml: any;
    constructor(private apiService: MyPageService) { }
    ngOnInit(): void {
        this.retrieveHtmlBody();
    }
    retrieveHtmlBody(): void {
        this.apiService.getAll()
            .subscribe(
                data => {
                    this.TemplateHtml = data;
                },
                error => {
                });
    } 
}
