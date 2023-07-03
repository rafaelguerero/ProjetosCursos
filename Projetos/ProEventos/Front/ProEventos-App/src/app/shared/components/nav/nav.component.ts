import { AccountService } from './../../../services/account.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss'],
})
export class NavComponent implements OnInit {
  public isCollapsed: boolean = true;
  public usuarioLogado = false;

  constructor(public accountService: AccountService, private router: Router) {}

  ngOnInit(): void {}

  public logout(): void {
    this.accountService.logout();
    this.router.navigateByUrl('/user/login');
  }

  protected showMenu(): boolean {
    return this.router.url !== '/user/login';
  }
}
