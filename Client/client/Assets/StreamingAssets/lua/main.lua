

require "define"

function main()
    print("123", "456", 420, "王虎", 1.35)

    local testui = require("ui/ui_test/ui_test")
    testui.show();

    local util = require '3rd/xlua/util'
    util.print_func_ref_by_csharp()
end

main();




