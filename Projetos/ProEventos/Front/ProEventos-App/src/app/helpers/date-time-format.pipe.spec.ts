import { DateTimeFormatPipe } from './date-time-format.pipe';

describe('Pipe: DateTimeFormate', () => {
  it('create an instance', () => {
    let pipe = new DateTimeFormatPipe('pt-BR');
    expect(pipe).toBeTruthy();
  });
});
