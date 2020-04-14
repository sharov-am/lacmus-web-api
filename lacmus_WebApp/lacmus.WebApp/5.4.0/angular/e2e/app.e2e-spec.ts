import { WebAppTemplatePage } from './app.po';

describe('WebApp App', function() {
  let page: WebAppTemplatePage;

  beforeEach(() => {
    page = new WebAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
