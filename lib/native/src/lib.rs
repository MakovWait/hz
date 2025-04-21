#[no_mangle]
pub extern "C" fn add_numbers(a: i32, b: i32) -> i32 {
    let vec = vec![a, b];
    println!("Hello from rust!");
    vec[0] + vec[1]
}