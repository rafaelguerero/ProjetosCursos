import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import {
  AbstractControlOptions,
  FormBuilder,
  FormGroup,
  Validators,
} from '@angular/forms';
import { Router } from '@angular/router';
import { ValidatorField } from '@app/helpers/ValidatorField';
import { UserUpdate } from '@app/models/Identity/UserUpdate';
import { AccountService } from '@app/services/account.service';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-perfil-detalhe',
  templateUrl: './perfil-detalhe.component.html',
  styleUrls: ['./perfil-detalhe.component.scss'],
})
export class PerfilDetalheComponent implements OnInit {
  @Output() changeFormValue = new EventEmitter();
  public formPerfil: FormGroup;
  public userUpdate = {} as UserUpdate;

  public get formControls(): any {
    return this.formPerfil.controls;
  }

  constructor(
    private _formBuilder: FormBuilder,
    public accountService: AccountService,
    private _router: Router,
    private _toaster: ToastrService,
    private _spinner: NgxSpinnerService
  ) {
    this.validation();
  }

  ngOnInit() {
    this.validation();
    this._carregarUsuario();
    this.verificaForm();
  }

  onSubmit(): void {
    this._atualizarUsuario();
  }

  private verificaForm(): void {
    this.formPerfil.valueChanges
      .subscribe(() => this.changeFormValue.emit({...this.formPerfil.value}))
  }

  private _carregarUsuario(): void {
    this._spinner.show();
    this.accountService
      .getUser()
      .subscribe({
        next: (userRetorno: UserUpdate) => {
          this.userUpdate = userRetorno;
          this.formPerfil.patchValue(this.userUpdate);
          this._toaster.success('Usuário carregado', 'Sucesso');
        },
        error: (err) => {
          console.log(err);
          this._toaster.error('Usuário não carregado', 'Erro');
          this._router.navigate(['/dashboard']);
        },
      })
      .add(() => this._spinner.hide());
  }

  private _atualizarUsuario(): void {
    this.userUpdate = { ...this.formPerfil.value };
    this._spinner.show();
    this.accountService
      .updateUser(this.userUpdate)
      .subscribe({
        next: () => {
          this._toaster.success('Usuário atualizado!', 'Sucesso');
        },
        error: (erro) => {
          this._toaster.error(erro.error);
        },
      })
      .add(() => this._spinner.hide());
  }

  private validation(): void {
    const formOptions: AbstractControlOptions = {
      validators: ValidatorField.MustMatch('password', 'confirmePassword'),
    };

    this.formPerfil = this._formBuilder.group(
      {
        titulo: ['NaoInformado', Validators.required],
        userName: [''],
        imageUrl: [''],
        primeiroNome: ['', Validators.required],
        ultimoNome: ['', Validators.required],
        email: ['', [Validators.required, Validators.email]],
        phoneNumber: ['', Validators.required],
        funcao: ['NaoInformado', Validators.required],
        descricao: ['', [Validators.required, Validators.maxLength(250)]],
        password: ['', [Validators.minLength(6), Validators.nullValidator]],
        confirmePassword: ['', Validators.nullValidator],
      },
      formOptions
    );
  }

  protected resetForm(): void {
    this.formPerfil.reset();
  }
}
