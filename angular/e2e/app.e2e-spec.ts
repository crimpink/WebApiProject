import { DotNetCoreWebApiProjectTemplatePage } from './app.po';

describe('DotNetCoreWebApiProject App', function() {
  let page: DotNetCoreWebApiProjectTemplatePage;

  beforeEach(() => {
    page = new DotNetCoreWebApiProjectTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
