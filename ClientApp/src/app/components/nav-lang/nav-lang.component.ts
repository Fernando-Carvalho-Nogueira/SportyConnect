import { Component } from '@angular/core';

@Component({
  selector: 'app-nav-lang',
  templateUrl: './nav-lang.component.html',
  styleUrls: ['./nav-lang.component.css']
})
export class NavLangComponent {

  lang:string = "";

  ngOnInit() {
    this.lang = localStorage.getItem("lang") || 'en'
  }

  changeLang(lang) {
    localStorage.setItem('lang', lang);
    window.location.reload();
  }
}
