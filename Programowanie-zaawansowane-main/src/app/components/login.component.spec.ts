import { LoginComponent } from './loginform/login.component';

describe('Testowanie componentu Login', () => {
  let testComponent: LoginComponent;
  let mockAuthService: any;
  let mockRouter: any;

  beforeEach(() => {
    mockAuthService = jasmine.createSpyObj('AuthService', ['login', 'logout']);
    mockRouter = jasmine.createSpyObj('Router', ['navigate']);

    testComponent = new LoginComponent(mockAuthService, mockRouter);
  });

  it('Prawidłowe dane uwierzytelniające umożliwiają zalogowanie się', () => {
    testComponent.formData.username = 'Liza';
    testComponent.formData.password = '1111';
    testComponent.login();
    expect(testComponent.formData.isLoged).toBe(true);
    expect(mockAuthService.login).toHaveBeenCalled();
  });

  it('Nieprawidłowe dane uwierzytelniające uniemożliwiają zalogowanie się', () => {
    testComponent.formData.username = 'Piotr';
    testComponent.formData.password = '666';
    testComponent.login();
    expect(testComponent.formData.isLoged).toBe(false);
    expect(mockAuthService.logout).toHaveBeenCalled();
  });
});
