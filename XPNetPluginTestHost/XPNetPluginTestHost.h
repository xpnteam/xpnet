#include <type_traits>
#include <utility>


// storage and fnptr here are some wrappers that make a lambda that
// includes captures be compatible with a C function pointer.  It's
// some hackery from stackoverflow; I'd want to understand it a little
// better to use in production code (it looks like it's not safe to use
// more than one at a time...) but it's useful enough for the test
// harness.

template<typename Callable>
union storage
{
	storage() {}
	std::decay_t<Callable> callable;
};

template<int, typename Callable, typename Ret, typename... Args>
auto fnptr_(Callable&& c, Ret(*)(Args...))
{
	static bool used = false;
	static storage<Callable> s;
	using type = decltype(s.callable);

	if (used)
		s.callable.~type();
	new (&s.callable) type(std::forward<Callable>(c));
	used = true;

	return [](Args... args) -> Ret {
		return Ret(s.callable(args...));
	};
}

template<typename Fn, int N = 0, typename Callable>
Fn* fnptr(Callable&& c)
{
	return fnptr_<N>(std::forward<Callable>(c), (Fn*)nullptr);
}
