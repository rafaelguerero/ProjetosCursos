import { UserUpdate } from '@app/models/Identity/UserUpdate';
import { Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { AccountService } from '@app/services/account.service';
import { environment } from '@environments/environment';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.scss'],
})
export class PerfilComponent implements OnInit {
  public usuario = {} as UserUpdate;
  public file: File;
  public imagemURL = '';

  public get ehPalestrante(): boolean {
    return this.usuario.funcao === 'Palestrante';
  }

  constructor(
    private spinner: NgxSpinnerService,
    private toastr: ToastrService,
    private accountService: AccountService
  ) {}

  ngOnInit(): void {}

  public setFormValue(usuario: UserUpdate): void {
    this.usuario = usuario;
    if (this.usuario.imageUrl)
      this.imagemURL =
        environment.apiUrl + `resources/perfil/${this.usuario.imageUrl}`;
    else this.imagemURL = './assets/img/perfil.png';
  }

  onFileChange(ev: any): void {
    const reader = new FileReader();

    reader.onload = (event: any) => (this.imagemURL = event.target.result);

    this.file = ev.target.files;
    reader.readAsDataURL(this.file[0]);

    this.uploadImagem();
  }

  private uploadImagem(): void {
    this.spinner.show();
    this.accountService
      .postUpload(this.file)
      .subscribe({
        next: () => {
          this.toastr.success('Imagem atualizada com Sucesso', 'Sucesso!');
        },
        error: () => {
          this.toastr.error('Erro ao fazer upload de imagem', 'Erro!');
        },
      })
      .add(() => this.spinner.hide());
  }
}
