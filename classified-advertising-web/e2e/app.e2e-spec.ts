import { ClassifiedAdvertisingWebPage } from './app.po';

describe('classified-advertising-web App', () => {
  let page: ClassifiedAdvertisingWebPage;

  beforeEach(() => {
    page = new ClassifiedAdvertisingWebPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
